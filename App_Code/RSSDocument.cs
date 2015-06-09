using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace net.uyghurdev.lab
{
    /// <summary>
    /// RSS ھۆججىتى
    /// <para>تۈزگۈچى: ئەلى ئەركىن</para>
    /// <para>ئۇيغۇر يۇمشاق دېتال ئىجادىيەت تورى</para>
    /// <para>www.UyghurDev.net</para>
    /// </summary>
    public class RSSDocument
    {
        private const string Generator = "UyghurDev RSS Generator/1.0";
        private string _XmlVersion = "1.0";
        /// <summary>
        /// XML نەشرى
        /// </summary>
        public string XmlVersion
        {
            get
            {
                return _XmlVersion;
            }
            set
            {
                _XmlVersion = value;
            }
        }

        private string _XmlEncoding = "UTF-8";
        /// <summary>
        /// XML كود ئۆلچىمى
        /// </summary>
        public string XmlEncoding
        {
            get
            {
                return _XmlEncoding;
            }
            set
            {
                _XmlEncoding = value;
            }
        }

        private string _RssVersion = "2.0";
        /// <summary>
        /// RSS نەشرى
        /// </summary>
        public string RssVersion
        {
            get
            {
                return _RssVersion;
            }
            set
            {
                _RssVersion = value;
            }
        }

        private List<RSSChannel> _Channel=new List<RSSChannel>();
        /// <summary>
        /// قانال
        /// </summary>
        public List<RSSChannel> Channel
        {
            get
            {
                return _Channel;
            }
            set
            {
                _Channel = value;
            }
        }

        /// <summary>
        /// RSS ھۆججىتى قۇرغۇچى فۇنكىسسىيەسى
        /// </summary>
        public RSSDocument()
        {

        }

        /// <summary>
        /// قانال قوشۇش
        /// </summary>
        /// <param name="newChannel">يىڭى قانال</param>
        public void AddChannel(RSSChannel newChannel)
        {
            _Channel.Add(newChannel);
        }

        /// <summary>
        /// تېكىستكە ئايلاندۇرۇش
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            /**
            <?xml version="1.0" encoding="UTF-8" ?>
    <rss version="2.0">
    <channel>
        <title>RSS Title</title>
        <description>This is an example of an RSS feed</description>
        <link>http://www.uyghurDev.net/main.html</link>
        <lastBuildDate>Mon, 06 Sep 2010 00:01:00 +0000 </lastBuildDate>
        <pubDate>Mon, 06 Sep 2009 16:45:00 +0000 </pubDate>
 
        <item>
            <title>Example entry</title>
            <description>Here is some text containing an interesting description of the thing to be described.</description>
            <link>http://www.uyghurdev.net/Content?id=173</link>
            <guid>unique string per item</guid>
            <pubDate>Mon, 06 Sep 2009 16:45:00 +0000 </pubDate>
        </item>
 
    </channel>
    </rss>
             * */
            StringBuilder sbRss = new StringBuilder();
            sbRss.AppendLine(string.Format("<?xml version=\"{0}\" encoding=\"{1}\" ?>", XmlVersion, XmlEncoding));
            sbRss.AppendLine(string.Format("<rss version=\"{0}\">", RssVersion));

            foreach (RSSChannel channel in Channel)
            {
                sbRss.AppendLine("<channel>");
                sbRss.AppendLine(string.Format("<title>{0}</title>", channel.Title));
                sbRss.AppendLine(string.Format("<description>{0}</description>", channel.Description));
                sbRss.AppendLine(string.Format("<link>{0}</link>", channel.Link));
                sbRss.AppendLine(string.Format("<lastBuildDate>{0}</lastBuildDate>", channel.LastBuildDate.ToString()));
                sbRss.AppendLine(string.Format("<pubDate>{0}</pubDate>", channel.PubDate.ToString()));
                sbRss.AppendLine(string.Format("<generator>{0}</generator>", Generator));
                foreach (RSSItem item in channel.Items)
                {
                    sbRss.AppendLine("<item>");
                    sbRss.AppendLine(string.Format("<title>{0}</title>", item.Title));
                    sbRss.AppendLine(string.Format("<description>{0}</description>", item.Description));
                    sbRss.AppendLine(string.Format("<link>{0}</link>", item.Link));
                    sbRss.AppendLine(string.Format("<pubDate>{0}</pubDate>", item.PubDate.ToString()));
                    sbRss.AppendLine("</item>");
                }
                sbRss.AppendLine("</channel>");
            }
            sbRss.AppendLine("</rss>");
            return sbRss.ToString();
        }
    }
}