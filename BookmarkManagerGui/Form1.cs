using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
using System.Diagnostics;
using System.Security.Policy;
using System.Reflection.Metadata.Ecma335;

namespace BookmarkManagerGui
{
    public partial class BookmarkManagerForm : Form
    {
        private const string Filename = @"C:\Users\karl80355\OneDrive - Willis Towers Watson\Documents\Bookmarks.yaml";
        private const string Filename2 = @"C:\Users\karl80355\OneDrive - Willis Towers Watson\Documents\Bookmarks2.yaml";

        private BookmarkStore bookmarks;

        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {

            //BookmarkStore bookmarks2 = new BookmarkStore();
            //bookmarks2.Bookmarks.Add(new Bookmark() { Name="name3", Address="address3" });
            //bookmarks2.Bookmarks.Add(new Bookmark() { Name = "name4", Address = "address4" });
            //SaveBookmarks(bookmarks2);

            RefreshBookmarks();
        }

        private void CboFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OpenSelectedBookmark();
            }
        }

        private void CboFilter_TextChanged(object sender, EventArgs e)
        {
            DisplayBookmarks(FilterBookmarks());
        }

        private void MiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MiOpen_Click(object sender, EventArgs e)
        {
            OpenSelectedBookmark();
        }

        private void MiRefresh_Click(object sender, EventArgs e)
        {
            RefreshBookmarks();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            OpenSelectedBookmark();
        }

        private void RefreshBookmarks()
        {
            bookmarks = LoadBookmarks();
            bookmarks.Bookmarks.Sort((a, b) => { return a.Name.CompareTo(b.Name); });
            DisplayBookmarks(FilterBookmarks());
        }

        private BookmarkStore LoadBookmarks()
        {
            string yml = File.ReadAllText(Filename);
            var deserializer = new DeserializerBuilder()
                //.WithNamingConvention(UnderscoredNamingConvention.Instance)  // see height_in_inches in sample yml 
                .Build();

            var p = deserializer.Deserialize<BookmarkStore>(yml);
            return p;
        }

        private IEnumerable<Bookmark> FilterBookmarks()
        {
            var searchTerms = CboFilter.Text.ToUpperInvariant().Split();
            foreach (var item in bookmarks.Bookmarks)
            {
                bool isMatch = true;
                foreach (var searchTerm in searchTerms)
                {
                    if (!item.Name.ToUpperInvariant().Contains(searchTerm))
                    {
                        isMatch = false;
                        break;
                    }
                }

                if (isMatch)
                {
                    yield return item;
                }
            }
        }

        private void DisplayBookmarks(IEnumerable<Bookmark> filteredBookmarks)
        {
            listView1.Items.Clear();
            bool isFirst = true;
            foreach (var bookmark in filteredBookmarks)
            {
                var item = listView1.Items.Add(bookmark.Name);
                item.SubItems.Add(bookmark.Address);
                item.Tag = bookmark;

                if (isFirst)
                {
                    item.Selected = true;
                    isFirst = false;
                }
            }

            if (bookmarks.Bookmarks.Count > 0)
            {
                ChName.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                ChAddress.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            else
            {
                ChName.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                ChAddress.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            TsLblStatus.Text = String.Format("Viewing: {0}/{1}", listView1.Items.Count, bookmarks.Bookmarks.Count);
        }

        private void OpenSelectedBookmark()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var bookmark = listView1.SelectedItems[0].Tag as Bookmark;
                if (bookmark != null)
                {
                    var url = bookmark.Address.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
            }
        }

        private void CboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //    private void SaveBookmarks(BookmarkStore bookmarks)
        //    {
        //        var serializer = new SerializerBuilder()
        ////.WithNamingConvention(CamelCaseNamingConvention.Instance)
        //.Build();
        //        var yaml = serializer.Serialize(bookmarks);
        //        File.WriteAllText(Filename2, yaml);
        //    }
    }
}