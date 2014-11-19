//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 0.3.5436.29315.
namespace IS24RestApi.Offer.Premiumplacement
{
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para xml:lang="de-DE">Liste von Premiumplacements</para>
    /// <para xml:lang="en">List of Premiumplacements</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5436.29315")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("Premiumplacements", Namespace="http://rest.immobilienscout24.de/schema/offer/premiumplacement/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("premiumplacements", Namespace="http://rest.immobilienscout24.de/schema/offer/premiumplacement/1.0")]
    public partial class Premiumplacements
    {
        
        /// <summary>
        /// <para xml:lang="de-DE">ein Anhang</para>
        /// <para xml:lang="en">an attachment</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("premiumplacement", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Collection<Premiumplacement> Premiumplacement { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Premiumplacement-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Premiumplacement collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PremiumplacementSpecified
        {
            get
            {
                return (this.Premiumplacement.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Premiumplacements" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Premiumplacements" /> class.</para>
        /// </summary>
        public Premiumplacements()
        {
            this.Premiumplacement = new Collection<Premiumplacement>();
        }
        
        /// <summary>
        /// <para xml:lang="de-DE">Link zum Element.</para>
        /// <para xml:lang="en">Link to the entity entry.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("href", Namespace="http://www.w3.org/1999/xlink", DataType="anyURI")]
        public string Href { get; set; }
    }
    
    /// <summary>
    /// <para xml:lang="de-DE">Premiumplacement</para>
    /// <para xml:lang="en">premium placement.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5436.29315")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("Premiumplacement", Namespace="http://rest.immobilienscout24.de/schema/offer/premiumplacement/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("premiumplacement", Namespace="http://rest.immobilienscout24.de/schema/offer/premiumplacement/1.0")]
    public partial class Premiumplacement
    {
        
        /// <summary>
        /// <para xml:lang="de-DE">Leistung gebucht von/bis</para>
        /// <para xml:lang="en">the period in which a service is active/available</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("servicePeriod", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IS24RestApi.Common.DateRange ServicePeriod { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Id des Immobilienobjektes.</para>
        /// <para xml:lang="en">Id of realestate.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("realestateid", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Realestateid { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Rabattkode</para>
        /// <para xml:lang="en">voucher number.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("voucher", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Voucher { get; set; }
    }
}
