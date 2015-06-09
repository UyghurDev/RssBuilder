using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;

namespace net.uyghurdev.lab
{
    /// <summary>
    /// RSS قانال
    /// <para>تۈزگۈچى: ئەلى ئەركىن</para>
    /// <para>ئۇيغۇر يۇمشاق دېتال ئىجادىيەت تورى</para>
    /// <para>www.UyghurDev.net</para>
    /// </summary>
    public class RSSChannel
    {
        private string _Title;
        /// <summary>
        /// تىمىسى
        /// </summary>
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private string _Description;
        /// <summary>
        /// چۈشەندۈرلىشى
        /// </summary>
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        private string _Link;
        /// <summary>
        /// ئۇلىنىش
        /// </summary>
        public string Link
        {
            get { return _Link; }
            set { _Link = value; }
        }

        private DateTime _LastBuildDate;
        /// <summary>
        /// ئاخىرقى ھاسىل قىلىنغان ۋاقتى
        /// </summary>
        public DateTime LastBuildDate
        {
            get { return _LastBuildDate; }
            set { _LastBuildDate = value; }
        }

        private DateTime _PubDate;
        /// <summary>
        /// ۋاقتى
        /// </summary>
        public DateTime PubDate
        {
            get { return _PubDate; }
            set { _PubDate = value; }
        }

        private List<RSSItem> _Items=new List<RSSItem>();
        /// <summary>
        /// ئەزالىرى
        /// </summary>
        public List<RSSItem> Items
        {
            get { return _Items; }
            set { _Items = value; }
        }

        /// <summary>
        /// RSS قانال- قۇرغۇچى فۇنكىسسىيەسى
        /// </summary>
        public RSSChannel()
        {
        }

        /// <summary>
        /// RSS قانال- قۇرغۇچى فۇنكىسسىيەسى
        /// </summary>
        /// <param name="strTitle">تىمىسى</param>
        /// <param name="strDescription">چۈشەندۈرلىشى</param>
        /// <param name="strLink">ئۇلىنىش</param>
        /// <param name="dtPubDate">ۋاقتى</param>
        /// <param name="dtLastBuildDate">ئاخىرقى ھاسىل قىلىنغان ۋاقتى</param>
        public RSSChannel(string strTitle, string strDescription, string strLink, DateTime dtPubDate, DateTime dtLastBuildDate)
        {
            _Title = strTitle;
            _Description = strDescription;
            _Link = strLink;
            _LastBuildDate = dtLastBuildDate;
            _PubDate = dtPubDate;
        }

        /// <summary>
        /// RSS قانال- قۇرغۇچى فۇنكىسسىيەسى
        /// </summary>
        /// <param name="strTitle">تىمىسى</param>
        /// <param name="strDescription">چۈشەندۈرلىشى</param>
        /// <param name="strLink">ئۇلىنىش</param>
        /// <param name="dtPubDate">ۋاقتى</param>
        /// <param name="dtLastBuildDate">ئاخىرقى ھاسىل قىلىنغان ۋاقتى</param>
        /// <param name="lstItems">ئەزالىرى</param>
        public RSSChannel(string strTitle, string strDescription, string strLink, DateTime dtPubDate, DateTime dtLastBuildDate, List<RSSItem> lstItems)
        {
            _Title = strTitle;
            _Description = strDescription;
            _Link = strLink;
            _LastBuildDate = dtLastBuildDate;
            _PubDate = dtPubDate;
            _Items = lstItems;
        }

        /// <summary>
        /// ئەزا قوشۇش
        /// </summary>
        /// <param name="NewItem">ئەزا</param>
        public void AddItem(RSSItem NewItem)
        {
            _Items.Add(NewItem);
        }
    }
}