using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml.Linq;

namespace SnakeSoft.Feed
{
    public static class FeedWordPressExtensionsMethods
    {
        public static string GetEncodedContent(this SyndicationItem val)
        {
            string result = String.Empty;

            foreach (SyndicationElementExtension extension in val.ElementExtensions)
            {
                XElement extensionElement = extension.GetObject<XElement>();

                if (extensionElement.Name.LocalName == "encoded" && extensionElement.Name.NamespaceName == "http://purl.org/rss/1.0/modules/content/")
                    result = extensionElement.Value;
            }

            return result;
        }

        public static string GetDcCreator(this SyndicationItem val)
        {
            string result = String.Empty;

            foreach (SyndicationElementExtension extension in val.ElementExtensions)
            {
                XElement extensionElement = extension.GetObject<XElement>();

                if (extensionElement.Name.LocalName == "creator" && extensionElement.Name.NamespaceName == "http://purl.org/dc/elements/1.1/")
                    result = extensionElement.Value;
            }

            return result;
        }

        public static string GetCommentsUrl(this SyndicationItem val)
        {
            string result = String.Empty;

            foreach (SyndicationElementExtension extension in val.ElementExtensions)
            {
                XElement extensionElement = extension.GetObject<XElement>();

                if (extensionElement.Name.LocalName == "comments" &&
                    extensionElement.Name.NamespaceName == "")
                    result = extensionElement.Value;
            }

            return result;
        }

        public static int GetCommentsCount(this SyndicationItem val)
        {
            int result = 0;

            foreach (SyndicationElementExtension extension in val.ElementExtensions)
            {
                XElement extensionElement = extension.GetObject<XElement>();

                if (extensionElement.Name.LocalName == "comments" && extensionElement.Name.NamespaceName == "http://purl.org/rss/1.0/modules/slash/")
                    result = Convert.ToInt32(extensionElement.Value);
            }

            return result;
        }
    }
}