//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18034
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Beetle.Express
{
    
    
    /// <summary>
    /// The ServerSection Configuration Section.
    /// </summary>
    public partial class ServerSection : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the ServerSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string ServerSectionSectionName = "serverSection";
        
        /// <summary>
        /// Gets the ServerSection instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public static global::Beetle.Express.ServerSection Instance
        {
            get
            {
                return ((global::Beetle.Express.ServerSection)(global::System.Configuration.ConfigurationManager.GetSection(global::Beetle.Express.ServerSection.ServerSectionSectionName)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Express.ServerSection.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::Beetle.Express.ServerSection.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Listens Property
        /// <summary>
        /// The XML name of the <see cref="Listens"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string ListensPropertyName = "listens";
        
        /// <summary>
        /// Gets or sets the Listens.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Listens.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Express.ServerSection.ListensPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::Beetle.Express.ListenCollection Listens
        {
            get
            {
                return ((global::Beetle.Express.ListenCollection)(base[global::Beetle.Express.ServerSection.ListensPropertyName]));
            }
            set
            {
                base[global::Beetle.Express.ServerSection.ListensPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace Beetle.Express
{
    
    
    /// <summary>
    /// The Listen Configuration Element.
    /// </summary>
    public partial class Listen : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Name Property
        /// <summary>
        /// The XML name of the <see cref="Name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string NamePropertyName = "name";
        
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Name.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Express.Listen.NamePropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Name
        {
            get
            {
                return ((string)(base[global::Beetle.Express.Listen.NamePropertyName]));
            }
            set
            {
                base[global::Beetle.Express.Listen.NamePropertyName] = value;
            }
        }
        #endregion
        
        #region Port Property
        /// <summary>
        /// The XML name of the <see cref="Port"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string PortPropertyName = "port";
        
        /// <summary>
        /// Gets or sets the Port.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Port.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Express.Listen.PortPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual int Port
        {
            get
            {
                return ((int)(base[global::Beetle.Express.Listen.PortPropertyName]));
            }
            set
            {
                base[global::Beetle.Express.Listen.PortPropertyName] = value;
            }
        }
        #endregion
        
        #region Host Property
        /// <summary>
        /// The XML name of the <see cref="Host"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string HostPropertyName = "host";
        
        /// <summary>
        /// Gets or sets the Host.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Host.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Express.Listen.HostPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string Host
        {
            get
            {
                return ((string)(base[global::Beetle.Express.Listen.HostPropertyName]));
            }
            set
            {
                base[global::Beetle.Express.Listen.HostPropertyName] = value;
            }
        }
        #endregion
        
        #region SendBufferSize Property
        /// <summary>
        /// The XML name of the <see cref="SendBufferSize"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string SendBufferSizePropertyName = "sendBufferSize";
        
        /// <summary>
        /// Gets or sets the SendBufferSize.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The SendBufferSize.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Express.Listen.SendBufferSizePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false, DefaultValue=4096)]
        public virtual int SendBufferSize
        {
            get
            {
                return ((int)(base[global::Beetle.Express.Listen.SendBufferSizePropertyName]));
            }
            set
            {
                base[global::Beetle.Express.Listen.SendBufferSizePropertyName] = value;
            }
        }
        #endregion
        
        #region ReceiveBufferSize Property
        /// <summary>
        /// The XML name of the <see cref="ReceiveBufferSize"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string ReceiveBufferSizePropertyName = "receiveBufferSize";
        
        /// <summary>
        /// Gets or sets the ReceiveBufferSize.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The ReceiveBufferSize.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Express.Listen.ReceiveBufferSizePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false, DefaultValue=4096)]
        public virtual int ReceiveBufferSize
        {
            get
            {
                return ((int)(base[global::Beetle.Express.Listen.ReceiveBufferSizePropertyName]));
            }
            set
            {
                base[global::Beetle.Express.Listen.ReceiveBufferSizePropertyName] = value;
            }
        }
        #endregion
        
        #region ReceiveDataPoolSize Property
        /// <summary>
        /// The XML name of the <see cref="ReceiveDataPoolSize"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string ReceiveDataPoolSizePropertyName = "receiveDataPoolSize";
        
        /// <summary>
        /// Gets or sets the ReceiveDataPoolSize.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The ReceiveDataPoolSize.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Express.Listen.ReceiveDataPoolSizePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false, DefaultValue=1000)]
        public virtual int ReceiveDataPoolSize
        {
            get
            {
                return ((int)(base[global::Beetle.Express.Listen.ReceiveDataPoolSizePropertyName]));
            }
            set
            {
                base[global::Beetle.Express.Listen.ReceiveDataPoolSizePropertyName] = value;
            }
        }
        #endregion
        
        #region Handler Property
        /// <summary>
        /// The XML name of the <see cref="Handler"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string HandlerPropertyName = "handler";
        
        /// <summary>
        /// Gets or sets the Handler.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Handler.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Express.Listen.HandlerPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string Handler
        {
            get
            {
                return ((string)(base[global::Beetle.Express.Listen.HandlerPropertyName]));
            }
            set
            {
                base[global::Beetle.Express.Listen.HandlerPropertyName] = value;
            }
        }
        #endregion
        
        #region Type Property
        /// <summary>
        /// The XML name of the <see cref="Type"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string TypePropertyName = "type";
        
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Type.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Express.Listen.TypePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false, DefaultValue="TCP")]
        public virtual string Type
        {
            get
            {
                return ((string)(base[global::Beetle.Express.Listen.TypePropertyName]));
            }
            set
            {
                base[global::Beetle.Express.Listen.TypePropertyName] = value;
            }
        }
        #endregion
        
        #region Dispatchs Property
        /// <summary>
        /// The XML name of the <see cref="Dispatchs"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string DispatchsPropertyName = "dispatchs";
        
        /// <summary>
        /// Gets or sets the Dispatchs.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Dispatchs.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Express.Listen.DispatchsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false, DefaultValue=3)]
        public virtual int Dispatchs
        {
            get
            {
                return ((int)(base[global::Beetle.Express.Listen.DispatchsPropertyName]));
            }
            set
            {
                base[global::Beetle.Express.Listen.DispatchsPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace Beetle.Express
{
    
    
    /// <summary>
    /// A collection of Listen instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::Beetle.Express.Listen), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.AddRemoveClearMap, AddItemName="add", RemoveItemName="remove", ClearItemsName="clear")]
    public partial class ListenCollection : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::Beetle.Express.Listen"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string ListenPropertyName = "serverListen";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.AddRemoveClearMap;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        protected override string ElementName
        {
            get
            {
                return global::Beetle.Express.ListenCollection.ListenPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::Beetle.Express.ListenCollection.ListenPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::Beetle.Express.Listen)(element)).Name;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::Beetle.Express.Listen"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::Beetle.Express.Listen"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::Beetle.Express.Listen();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::Beetle.Express.Listen"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::Beetle.Express.Listen"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public global::Beetle.Express.Listen this[int index]
        {
            get
            {
                return ((global::Beetle.Express.Listen)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::Beetle.Express.Listen"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::Beetle.Express.Listen"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public global::Beetle.Express.Listen this[object name]
        {
            get
            {
                return ((global::Beetle.Express.Listen)(base.BaseGet(name)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::Beetle.Express.Listen"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="serverListen">The <see cref="global::Beetle.Express.Listen"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public void Add(global::Beetle.Express.Listen serverListen)
        {
            base.BaseAdd(serverListen);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::Beetle.Express.Listen"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="serverListen">The <see cref="global::Beetle.Express.Listen"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public void Remove(global::Beetle.Express.Listen serverListen)
        {
            base.BaseRemove(this.GetElementKey(serverListen));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::Beetle.Express.Listen"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::Beetle.Express.Listen"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public global::Beetle.Express.Listen GetItemAt(int index)
        {
            return ((global::Beetle.Express.Listen)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::Beetle.Express.Listen"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::Beetle.Express.Listen"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public global::Beetle.Express.Listen GetItemByKey(string name)
        {
            return ((global::Beetle.Express.Listen)(base.BaseGet(((object)(name)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}
