using System.Windows.Forms;
using System.Diagnostics;
using System.Web;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
        string newStr = HttpUtility.UrlEncode(textBox1.Text);
        Process.Start("https://filecr.com/?s=" + newStr);
        Process.Start("https://getintopc.com/?s=" + newStr);
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            button1.PerformClick();
        }
    }
}