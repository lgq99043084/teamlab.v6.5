// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Ascensio System Limited" file="Proceed.cs">
// //   
// // </copyright>
// // <summary>
// //   (c) Copyright Ascensio System Limited 2008-2012
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using ASC.Xmpp.Core.utils.Xml.Dom;

namespace ASC.Xmpp.Core.protocol.tls
{

    #region usings

    #endregion

    // Step 5: Server informs client that it is allowed to proceed:
    // <proceed xmlns='urn:ietf:params:xml:ns:xmpp-tls'/>

    /// <summary>
    ///   Summary description for Proceed.
    /// </summary>
    public class Proceed : Element
    {
        #region Constructor

        /// <summary>
        /// </summary>
        public Proceed()
        {
            TagName = "proceed";
            Namespace = Uri.TLS;
        }

        #endregion
    }
}