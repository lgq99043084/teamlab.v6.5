// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Ascensio System Limited" file="Note.cs">
// //   
// // </copyright>
// // <summary>
// //   (c) Copyright Ascensio System Limited 2008-2012
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using ASC.Xmpp.Core.utils.Xml.Dom;

namespace ASC.Xmpp.Core.protocol.extensions.commands
{
    /*
        <note type='info'>Service 'httpd' has been configured.</note>
        
        <xs:element name='note'>
            <xs:complexType>
              <xs:simpleContent>
                <xs:extension base='xs:string'>
                  <xs:attribute name='type' use='required'>
                    <xs:simpleType>
                      <xs:restriction base='xs:NCName'>
                        <xs:enumeration value='error'/>
                        <xs:enumeration value='info'/>
                        <xs:enumeration value='warn'/>
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:attribute>
                </xs:extension>
              </xs:simpleContent>
            </xs:complexType>
        </xs:element>
    */

    public class Note : Element
    {
        /// <summary>
        ///   Default constructor
        /// </summary>
        public Note()
        {
            TagName = "note";
            Namespace = Uri.COMMANDS;
        }

        /// <summary>
        /// </summary>
        /// <param name="type"> </param>
        public Note(NoteType type) : this()
        {
            Type = type;
        }

        /// <summary>
        /// </summary>
        /// <param name="text"> </param>
        /// <param name="type"> </param>
        public Note(string text, NoteType type) : this(type)
        {
            Value = text;
        }

        public NoteType Type
        {
            get { return (NoteType) GetAttributeEnum("type", typeof (NoteType)); }
            set { SetAttribute("type", value.ToString()); }
        }
    }
}