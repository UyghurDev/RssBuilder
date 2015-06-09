using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using net.uyghurdev.lab;

public partial class RSS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Clear();
        Response.ContentType = "text/xml";
        RSSDocument Doc = new RSSDocument();//rss ھۆججەتنى ئىنىقلىدۇق
        RSSChannel Channel = new RSSChannel();//قانالنى ئىنىقلىدۇق

        //تۆۋەندىكىسى قانال ئۇچۇرى
        Channel.Title = "Uyghur Software Developer Network";
        Channel.Description = "this is description";
        Channel.Link = "www.uyghurdev.net";
        Channel.PubDate = DateTime.Now;
        Channel.LastBuildDate = DateTime.Now;
        for (int n = 0; n < 10; n++)
        {
            RSSItem item = new RSSItem();//بىر ئەزانى ئىنىقلىدۇق-بىر خەۋەر
            //خەۋەر مەزمۇنىنى خاتىرلىدۇق
            item.Title = "title"+n.ToString();
            item.Description = "description"+n.ToString();
            item.Link = "www.uyghurdev.net/topicid="+n.ToString();
            item.PubDate = DateTime.Now;//بۇ يەرگە خەۋەرنىڭ ئەسلى يوللانغان ۋاقتىنى بىرىمىز
            Channel.AddItem(item);//خەۋەرنى قانالغا قوشتۇق
        }

        Doc.Channel.Add(Channel);//قانالنى ھۆججەتكە قوشتۇق
        Response.Write(Doc.ToString());//ھۆججەتنى تورغا يوللىدۇق
        Response.End();
    }
}