using System;
using System.IO;
using System.ServiceModel.Syndication;
using System.Xml;

namespace SnakeSoft.Feed
{
    public static class Feed
    {
        /// <summary>
        /// Returns a SyndicationFeed object
        /// </summary>
        /// <param name="url">https://yourwordpress.com/feed</param>
        /// <returns></returns>
        public static SyndicationFeed GetFeed(string url)
        {
            SyndicationFeed result = null;

            try
            {
                using (var xmlReader = XmlReader.Create(url, new XmlReaderSettings() { Async = true }))
                {
                    result = SyndicationFeed.Load(xmlReader);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// Returns a SyndicationFeed object
        /// </summary>
        /// <param name="textReader"></param>
        /// <returns></returns>
        public static SyndicationFeed GetFeed(TextReader textReader)
        {
            SyndicationFeed result = null;

            try
            {
                using (var xmlReader = XmlReader.Create(textReader, new XmlReaderSettings() { Async = true }))
                {
                    result = SyndicationFeed.Load(xmlReader);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// Returns a SyndicationFeed object
        /// </summary>
        /// <param name="textReader"></param>
        /// <returns></returns>
        public static SyndicationFeed GetFeed(Stream stream)
        {
            SyndicationFeed result = null;

            try
            {
                using (var xmlReader = XmlReader.Create(stream, new XmlReaderSettings() { Async = true }))
                {
                    result = SyndicationFeed.Load(xmlReader);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}