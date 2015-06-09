using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace net.uyghurdev.lab
{
    /// <summary>
    /// RSS ئەزاسى
    /// <para>تۈزگۈچى: ئەلى ئەركىن</para>
    /// <para>ئۇيغۇر يۇمشاق دېتال ئىجادىيەت تورى</para>
    /// <para>www.UyghurDev.net</para>
    /// </summary>
    public class RSSItem
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
        /// مەزمۇنى
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

        private DateTime _PubDate;
        /// <summary>
        /// ۋاقتى
        /// </summary>
        public DateTime PubDate
        {
            get { return _PubDate; }
            set { _PubDate = value; }
        }


        /// <summary>
        /// ئەزا قۇرغۇچى فۇنكىسسىيەسى
        /// </summary>
        public RSSItem()
        {

        }

        /// <summary>
        /// ئەزا قۇرغۇچى فۇنكىسسىيەسى
        /// </summary>
        /// <param name="strTitle">تىمىسى</param>
        /// <param name="strDescription">مەزمۇنى</param>
        /// <param name="strLink">ئۇلىنىش</param>
        /// <param name="dtPubDate">ۋاقتى</param>
        public RSSItem(string strTitle, string strDescription, string strLink, DateTime dtPubDate)
        {
            _Title = strTitle;
            _Description = strDescription;
            _Link = strLink;
            _PubDate = dtPubDate;
        }

    }
}