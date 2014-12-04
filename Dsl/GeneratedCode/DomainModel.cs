﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;
namespace FourDeep.PDizzle
{
	/// <summary>
	/// DomainModel PDizzleDomainModel
	/// Description for FourDeep.PDizzle.PDizzle
	/// </summary>
	[DslDesign::DisplayNameResource("FourDeep.PDizzle.PDizzleDomainModel.DisplayName", typeof(global::FourDeep.PDizzle.PDizzleDomainModel), "FourDeep.PDizzle.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("FourDeep.PDizzle.PDizzleDomainModel.Description", typeof(global::FourDeep.PDizzle.PDizzleDomainModel), "FourDeep.PDizzle.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.CoreDomainModel))]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.Diagrams.CoreDesignSurfaceDomainModel))]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
	[DslModeling::DomainObjectId("42e47e27-c8b0-4982-a92d-b2b40f109b1c")]
	public partial class PDizzleDomainModel : DslModeling::DomainModel
	{
		#region Constructor, domain model Id
	
		/// <summary>
		/// PDizzleDomainModel domain model Id.
		/// </summary>
		public static readonly global::System.Guid DomainModelId = new global::System.Guid(0x42e47e27, 0xc8b0, 0x4982, 0xa9, 0x2d, 0xb2, 0xb4, 0x0f, 0x10, 0x9b, 0x1c);
	
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="store">Store containing the domain model.</param>
		public PDizzleDomainModel(DslModeling::Store store)
			: base(store, DomainModelId)
		{
			// Call the partial method to allow any required serialization setup to be done.
			this.InitializeSerialization(store);		
		}
		
	
		///<Summary>
		/// Defines a partial method that will be called from the constructor to
		/// allow any necessary serialization setup to be done.
		///</Summary>
		///<remarks>
		/// For a DSL created with the DSL Designer wizard, an implementation of this 
		/// method will be generated in the GeneratedCode\SerializationHelper.cs class.
		///</remarks>
		partial void InitializeSerialization(DslModeling::Store store);
	
	
		#endregion
		#region Domain model reflection
			
		/// <summary>
		/// Gets the list of generated domain model types (classes, rules, relationships).
		/// </summary>
		/// <returns>List of types.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override global::System.Type[] GetGeneratedDomainModelTypes()
		{
			return new global::System.Type[]
			{
				typeof(AggregateModel),
				typeof(AggregateRoot),
				typeof(DomainCommand),
				typeof(Property),
				typeof(View),
				typeof(DomainEvent),
				typeof(Entity),
				typeof(AggregateModelHasAggregateRoot),
				typeof(AggregateModelHasDomainCommands),
				typeof(AggregateModelHasProperties),
				typeof(AggregateModelHasViews),
				typeof(AggregateModelHandlesDomainEvents),
				typeof(AggregateModelHasEntities),
				typeof(DomainCommandHasProperties),
				typeof(ViewHasProperties),
				typeof(ViewHandlesDomainEvents),
				typeof(DomainEventHasProperties),
				typeof(EntityHasProperties),
				typeof(AggregateRootHasProperties),
				typeof(AggregateRootReferencesDomainCommands),
				typeof(AggregateRootReferencesDomainEvents),
				typeof(PDizzleDiagram),
				typeof(CommandConnector),
				typeof(DomainEventConnector),
				typeof(PropertyShape),
				typeof(DomainCommandShape),
				typeof(DomainEventShape),
				typeof(EntityShape),
				typeof(ViewShape),
				typeof(AggregateRootShape),
				typeof(global::FourDeep.PDizzle.FixUpDiagram),
				typeof(global::FourDeep.PDizzle.ConnectorRolePlayerChanged),
				typeof(global::FourDeep.PDizzle.CompartmentItemAddRule),
				typeof(global::FourDeep.PDizzle.CompartmentItemDeleteRule),
				typeof(global::FourDeep.PDizzle.CompartmentItemRolePlayerChangeRule),
				typeof(global::FourDeep.PDizzle.CompartmentItemRolePlayerPositionChangeRule),
				typeof(global::FourDeep.PDizzle.CompartmentItemChangeRule),
			};
		}
		/// <summary>
		/// Gets the list of generated domain properties.
		/// </summary>
		/// <returns>List of property data.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override DomainMemberInfo[] GetGeneratedDomainProperties()
		{
			return new DomainMemberInfo[]
			{
				new DomainMemberInfo(typeof(AggregateModel), "ModelNamespace", AggregateModel.ModelNamespaceDomainPropertyId, typeof(AggregateModel.ModelNamespacePropertyHandler)),
				new DomainMemberInfo(typeof(AggregateRoot), "Name", AggregateRoot.NameDomainPropertyId, typeof(AggregateRoot.NamePropertyHandler)),
				new DomainMemberInfo(typeof(AggregateRoot), "Description", AggregateRoot.DescriptionDomainPropertyId, typeof(AggregateRoot.DescriptionPropertyHandler)),
				new DomainMemberInfo(typeof(DomainCommand), "Name", DomainCommand.NameDomainPropertyId, typeof(DomainCommand.NamePropertyHandler)),
				new DomainMemberInfo(typeof(DomainCommand), "Description", DomainCommand.DescriptionDomainPropertyId, typeof(DomainCommand.DescriptionPropertyHandler)),
				new DomainMemberInfo(typeof(DomainCommand), "RequiredPrivilege", DomainCommand.RequiredPrivilegeDomainPropertyId, typeof(DomainCommand.RequiredPrivilegePropertyHandler)),
				new DomainMemberInfo(typeof(Property), "Order", Property.OrderDomainPropertyId, typeof(Property.OrderPropertyHandler)),
				new DomainMemberInfo(typeof(Property), "Name", Property.NameDomainPropertyId, typeof(Property.NamePropertyHandler)),
				new DomainMemberInfo(typeof(Property), "Type", Property.TypeDomainPropertyId, typeof(Property.TypePropertyHandler)),
				new DomainMemberInfo(typeof(Property), "Namespace", Property.NamespaceDomainPropertyId, typeof(Property.NamespacePropertyHandler)),
				new DomainMemberInfo(typeof(Property), "Description", Property.DescriptionDomainPropertyId, typeof(Property.DescriptionPropertyHandler)),
				new DomainMemberInfo(typeof(View), "Name", View.NameDomainPropertyId, typeof(View.NamePropertyHandler)),
				new DomainMemberInfo(typeof(View), "Description", View.DescriptionDomainPropertyId, typeof(View.DescriptionPropertyHandler)),
				new DomainMemberInfo(typeof(DomainEvent), "Name", DomainEvent.NameDomainPropertyId, typeof(DomainEvent.NamePropertyHandler)),
				new DomainMemberInfo(typeof(DomainEvent), "Description", DomainEvent.DescriptionDomainPropertyId, typeof(DomainEvent.DescriptionPropertyHandler)),
				new DomainMemberInfo(typeof(Entity), "Name", Entity.NameDomainPropertyId, typeof(Entity.NamePropertyHandler)),
				new DomainMemberInfo(typeof(Entity), "Description", Entity.DescriptionDomainPropertyId, typeof(Entity.DescriptionPropertyHandler)),
				new DomainMemberInfo(typeof(DomainCommandShape), "FillColor", DomainCommandShape.FillColorDomainPropertyId, typeof(DomainCommandShape.FillColorPropertyHandler)),
				new DomainMemberInfo(typeof(DomainCommandShape), "TextColor", DomainCommandShape.TextColorDomainPropertyId, typeof(DomainCommandShape.TextColorPropertyHandler)),
				new DomainMemberInfo(typeof(DomainCommandShape), "FillGradientMode", DomainCommandShape.FillGradientModeDomainPropertyId, typeof(DomainCommandShape.FillGradientModePropertyHandler)),
				new DomainMemberInfo(typeof(DomainEventShape), "FillColor", DomainEventShape.FillColorDomainPropertyId, typeof(DomainEventShape.FillColorPropertyHandler)),
				new DomainMemberInfo(typeof(DomainEventShape), "TextColor", DomainEventShape.TextColorDomainPropertyId, typeof(DomainEventShape.TextColorPropertyHandler)),
				new DomainMemberInfo(typeof(DomainEventShape), "FillGradientMode", DomainEventShape.FillGradientModeDomainPropertyId, typeof(DomainEventShape.FillGradientModePropertyHandler)),
				new DomainMemberInfo(typeof(EntityShape), "FillColor", EntityShape.FillColorDomainPropertyId, typeof(EntityShape.FillColorPropertyHandler)),
				new DomainMemberInfo(typeof(EntityShape), "FillGradientMode", EntityShape.FillGradientModeDomainPropertyId, typeof(EntityShape.FillGradientModePropertyHandler)),
				new DomainMemberInfo(typeof(EntityShape), "TextColor", EntityShape.TextColorDomainPropertyId, typeof(EntityShape.TextColorPropertyHandler)),
				new DomainMemberInfo(typeof(ViewShape), "FillColor", ViewShape.FillColorDomainPropertyId, typeof(ViewShape.FillColorPropertyHandler)),
				new DomainMemberInfo(typeof(ViewShape), "TextColor", ViewShape.TextColorDomainPropertyId, typeof(ViewShape.TextColorPropertyHandler)),
				new DomainMemberInfo(typeof(ViewShape), "FillGradientMode", ViewShape.FillGradientModeDomainPropertyId, typeof(ViewShape.FillGradientModePropertyHandler)),
				new DomainMemberInfo(typeof(AggregateRootShape), "FillColor", AggregateRootShape.FillColorDomainPropertyId, typeof(AggregateRootShape.FillColorPropertyHandler)),
				new DomainMemberInfo(typeof(AggregateRootShape), "TextColor", AggregateRootShape.TextColorDomainPropertyId, typeof(AggregateRootShape.TextColorPropertyHandler)),
				new DomainMemberInfo(typeof(AggregateRootShape), "FillGradientMode", AggregateRootShape.FillGradientModeDomainPropertyId, typeof(AggregateRootShape.FillGradientModePropertyHandler)),
			};
		}
		/// <summary>
		/// Gets the list of generated domain roles.
		/// </summary>
		/// <returns>List of role data.</returns>
		protected sealed override DomainRolePlayerInfo[] GetGeneratedDomainRoles()
		{
			return new DomainRolePlayerInfo[]
			{
				new DomainRolePlayerInfo(typeof(AggregateModelHasAggregateRoot), "AggregateModel", AggregateModelHasAggregateRoot.AggregateModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateModelHasAggregateRoot), "Element", AggregateModelHasAggregateRoot.ElementDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateModelHasDomainCommands), "AggregateModel", AggregateModelHasDomainCommands.AggregateModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateModelHasDomainCommands), "DomainCommand", AggregateModelHasDomainCommands.DomainCommandDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateModelHasProperties), "AggregateModel", AggregateModelHasProperties.AggregateModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateModelHasProperties), "Property", AggregateModelHasProperties.PropertyDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateModelHasViews), "AggregateModel", AggregateModelHasViews.AggregateModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateModelHasViews), "View", AggregateModelHasViews.ViewDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateModelHandlesDomainEvents), "AggregateModel", AggregateModelHandlesDomainEvents.AggregateModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateModelHandlesDomainEvents), "DomainEvent", AggregateModelHandlesDomainEvents.DomainEventDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateModelHasEntities), "AggregateModel", AggregateModelHasEntities.AggregateModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateModelHasEntities), "Entity", AggregateModelHasEntities.EntityDomainRoleId),
				new DomainRolePlayerInfo(typeof(DomainCommandHasProperties), "DomainCommand", DomainCommandHasProperties.DomainCommandDomainRoleId),
				new DomainRolePlayerInfo(typeof(DomainCommandHasProperties), "Property", DomainCommandHasProperties.PropertyDomainRoleId),
				new DomainRolePlayerInfo(typeof(ViewHasProperties), "View", ViewHasProperties.ViewDomainRoleId),
				new DomainRolePlayerInfo(typeof(ViewHasProperties), "Property", ViewHasProperties.PropertyDomainRoleId),
				new DomainRolePlayerInfo(typeof(ViewHandlesDomainEvents), "View", ViewHandlesDomainEvents.ViewDomainRoleId),
				new DomainRolePlayerInfo(typeof(ViewHandlesDomainEvents), "DomainEvent", ViewHandlesDomainEvents.DomainEventDomainRoleId),
				new DomainRolePlayerInfo(typeof(DomainEventHasProperties), "DomainEvent", DomainEventHasProperties.DomainEventDomainRoleId),
				new DomainRolePlayerInfo(typeof(DomainEventHasProperties), "Property", DomainEventHasProperties.PropertyDomainRoleId),
				new DomainRolePlayerInfo(typeof(EntityHasProperties), "Entity", EntityHasProperties.EntityDomainRoleId),
				new DomainRolePlayerInfo(typeof(EntityHasProperties), "Property", EntityHasProperties.PropertyDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateRootHasProperties), "AggregateRoot", AggregateRootHasProperties.AggregateRootDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateRootHasProperties), "Property", AggregateRootHasProperties.PropertyDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateRootReferencesDomainCommands), "AggregateRoot", AggregateRootReferencesDomainCommands.AggregateRootDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateRootReferencesDomainCommands), "DomainCommand", AggregateRootReferencesDomainCommands.DomainCommandDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateRootReferencesDomainEvents), "AggregateRoot", AggregateRootReferencesDomainEvents.AggregateRootDomainRoleId),
				new DomainRolePlayerInfo(typeof(AggregateRootReferencesDomainEvents), "DomainEvent", AggregateRootReferencesDomainEvents.DomainEventDomainRoleId),
			};
		}
		#endregion
		#region Factory methods
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementMap;
	
		/// <summary>
		/// Creates an element of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementType">Element type which belongs to this domain model.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		public sealed override DslModeling::ModelElement CreateElement(DslModeling::Partition partition, global::System.Type elementType, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementType == null) throw new global::System.ArgumentNullException("elementType");
	
			if (createElementMap == null)
			{
				createElementMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(16);
				createElementMap.Add(typeof(AggregateModel), 0);
				createElementMap.Add(typeof(AggregateRoot), 1);
				createElementMap.Add(typeof(DomainCommand), 2);
				createElementMap.Add(typeof(Property), 3);
				createElementMap.Add(typeof(View), 4);
				createElementMap.Add(typeof(DomainEvent), 5);
				createElementMap.Add(typeof(Entity), 6);
				createElementMap.Add(typeof(PDizzleDiagram), 7);
				createElementMap.Add(typeof(CommandConnector), 8);
				createElementMap.Add(typeof(DomainEventConnector), 9);
				createElementMap.Add(typeof(PropertyShape), 10);
				createElementMap.Add(typeof(DomainCommandShape), 11);
				createElementMap.Add(typeof(DomainEventShape), 12);
				createElementMap.Add(typeof(EntityShape), 13);
				createElementMap.Add(typeof(ViewShape), 14);
				createElementMap.Add(typeof(AggregateRootShape), 15);
			}
			int index;
			if (!createElementMap.TryGetValue(elementType, out index))
			{
				// construct exception error message		
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::FourDeep.PDizzle.PDizzleDomainModel.SingletonResourceManager.GetString("UnrecognizedElementType"),
								elementType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementType");
			}
			switch (index)
			{
				case 0: return new AggregateModel(partition, propertyAssignments);
				case 1: return new AggregateRoot(partition, propertyAssignments);
				case 2: return new DomainCommand(partition, propertyAssignments);
				case 3: return new Property(partition, propertyAssignments);
				case 4: return new View(partition, propertyAssignments);
				case 5: return new DomainEvent(partition, propertyAssignments);
				case 6: return new Entity(partition, propertyAssignments);
				case 7: return new PDizzleDiagram(partition, propertyAssignments);
				case 8: return new CommandConnector(partition, propertyAssignments);
				case 9: return new DomainEventConnector(partition, propertyAssignments);
				case 10: return new PropertyShape(partition, propertyAssignments);
				case 11: return new DomainCommandShape(partition, propertyAssignments);
				case 12: return new DomainEventShape(partition, propertyAssignments);
				case 13: return new EntityShape(partition, propertyAssignments);
				case 14: return new ViewShape(partition, propertyAssignments);
				case 15: return new AggregateRootShape(partition, propertyAssignments);
				default: return null;
			}
		}
	
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementLinkMap;
	
		/// <summary>
		/// Creates an element link of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementLinkType">Element link type which belongs to this domain model.</param>
		/// <param name="roleAssignments">List of relationship role assignments for the new link.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element link.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ElementLink CreateElementLink(DslModeling::Partition partition, global::System.Type elementLinkType, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementLinkType == null) throw new global::System.ArgumentNullException("elementLinkType");
			if (roleAssignments == null) throw new global::System.ArgumentNullException("roleAssignments");
	
			if (createElementLinkMap == null)
			{
				createElementLinkMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(14);
				createElementLinkMap.Add(typeof(AggregateModelHasAggregateRoot), 0);
				createElementLinkMap.Add(typeof(AggregateModelHasDomainCommands), 1);
				createElementLinkMap.Add(typeof(AggregateModelHasProperties), 2);
				createElementLinkMap.Add(typeof(AggregateModelHasViews), 3);
				createElementLinkMap.Add(typeof(AggregateModelHandlesDomainEvents), 4);
				createElementLinkMap.Add(typeof(AggregateModelHasEntities), 5);
				createElementLinkMap.Add(typeof(DomainCommandHasProperties), 6);
				createElementLinkMap.Add(typeof(ViewHasProperties), 7);
				createElementLinkMap.Add(typeof(ViewHandlesDomainEvents), 8);
				createElementLinkMap.Add(typeof(DomainEventHasProperties), 9);
				createElementLinkMap.Add(typeof(EntityHasProperties), 10);
				createElementLinkMap.Add(typeof(AggregateRootHasProperties), 11);
				createElementLinkMap.Add(typeof(AggregateRootReferencesDomainCommands), 12);
				createElementLinkMap.Add(typeof(AggregateRootReferencesDomainEvents), 13);
			}
			int index;
			if (!createElementLinkMap.TryGetValue(elementLinkType, out index))
			{
				// construct exception error message
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::FourDeep.PDizzle.PDizzleDomainModel.SingletonResourceManager.GetString("UnrecognizedElementLinkType"),
								elementLinkType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementLinkType");
			
			}
			switch (index)
			{
				case 0: return new AggregateModelHasAggregateRoot(partition, roleAssignments, propertyAssignments);
				case 1: return new AggregateModelHasDomainCommands(partition, roleAssignments, propertyAssignments);
				case 2: return new AggregateModelHasProperties(partition, roleAssignments, propertyAssignments);
				case 3: return new AggregateModelHasViews(partition, roleAssignments, propertyAssignments);
				case 4: return new AggregateModelHandlesDomainEvents(partition, roleAssignments, propertyAssignments);
				case 5: return new AggregateModelHasEntities(partition, roleAssignments, propertyAssignments);
				case 6: return new DomainCommandHasProperties(partition, roleAssignments, propertyAssignments);
				case 7: return new ViewHasProperties(partition, roleAssignments, propertyAssignments);
				case 8: return new ViewHandlesDomainEvents(partition, roleAssignments, propertyAssignments);
				case 9: return new DomainEventHasProperties(partition, roleAssignments, propertyAssignments);
				case 10: return new EntityHasProperties(partition, roleAssignments, propertyAssignments);
				case 11: return new AggregateRootHasProperties(partition, roleAssignments, propertyAssignments);
				case 12: return new AggregateRootReferencesDomainCommands(partition, roleAssignments, propertyAssignments);
				case 13: return new AggregateRootReferencesDomainEvents(partition, roleAssignments, propertyAssignments);
				default: return null;
			}
		}
		#endregion
		#region Resource manager
		
		private static global::System.Resources.ResourceManager resourceManager;
		
		/// <summary>
		/// The base name of this model's resources.
		/// </summary>
		public const string ResourceBaseName = "FourDeep.PDizzle.GeneratedCode.DomainModelResx";
		
		/// <summary>
		/// Gets the DomainModel's ResourceManager. If the ResourceManager does not already exist, then it is created.
		/// </summary>
		public override global::System.Resources.ResourceManager ResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return PDizzleDomainModel.SingletonResourceManager;
			}
		}
	
		/// <summary>
		/// Gets the Singleton ResourceManager for this domain model.
		/// </summary>
		public static global::System.Resources.ResourceManager SingletonResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				if (PDizzleDomainModel.resourceManager == null)
				{
					PDizzleDomainModel.resourceManager = new global::System.Resources.ResourceManager(ResourceBaseName, typeof(PDizzleDomainModel).Assembly);
				}
				return PDizzleDomainModel.resourceManager;
			}
		}
		#endregion
		#region Copy/Remove closures
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter copyClosure;
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter removeClosure;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override DslModeling::IElementVisitorFilter GetClosureFilter(DslModeling::ClosureType type, global::System.Collections.Generic.ICollection<DslModeling::ModelElement> rootElements)
		{
			switch (type)
			{
				case DslModeling::ClosureType.CopyClosure:
					return PDizzleDomainModel.CopyClosure;
				case DslModeling::ClosureType.DeleteClosure:
					return PDizzleDomainModel.DeleteClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (PDizzleDomainModel.copyClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter copyFilter = new DslModeling::ChainingElementVisitorFilter();
					copyFilter.AddFilter(new PDizzleCopyClosure());
					copyFilter.AddFilter(new DslModeling::CoreCopyClosure());
					copyFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceCopyClosure());
					
					PDizzleDomainModel.copyClosure = copyFilter;
				}
				return PDizzleDomainModel.copyClosure;
			}
		}
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter DeleteClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (PDizzleDomainModel.removeClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter removeFilter = new DslModeling::ChainingElementVisitorFilter();
					removeFilter.AddFilter(new PDizzleDeleteClosure());
					removeFilter.AddFilter(new DslModeling::CoreDeleteClosure());
					removeFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceDeleteClosure());
		
					PDizzleDomainModel.removeClosure = removeFilter;
				}
				return PDizzleDomainModel.removeClosure;
			}
		}
		#endregion
		#region Diagram rule helpers
		/// <summary>
		/// Enables rules in this domain model related to diagram fixup for the given store.
		/// If diagram data will be loaded into the store, this method should be called first to ensure
		/// that the diagram behaves properly.
		/// </summary>
		public static void EnableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.EnableRule(typeof(global::FourDeep.PDizzle.FixUpDiagram));
			ruleManager.EnableRule(typeof(global::FourDeep.PDizzle.ConnectorRolePlayerChanged));
			ruleManager.EnableRule(typeof(global::FourDeep.PDizzle.CompartmentItemAddRule));
			ruleManager.EnableRule(typeof(global::FourDeep.PDizzle.CompartmentItemDeleteRule));
			ruleManager.EnableRule(typeof(global::FourDeep.PDizzle.CompartmentItemRolePlayerChangeRule));
			ruleManager.EnableRule(typeof(global::FourDeep.PDizzle.CompartmentItemRolePlayerPositionChangeRule));
			ruleManager.EnableRule(typeof(global::FourDeep.PDizzle.CompartmentItemChangeRule));
		}
		
		/// <summary>
		/// Disables rules in this domain model related to diagram fixup for the given store.
		/// </summary>
		public static void DisableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.DisableRule(typeof(global::FourDeep.PDizzle.FixUpDiagram));
			ruleManager.DisableRule(typeof(global::FourDeep.PDizzle.ConnectorRolePlayerChanged));
			ruleManager.DisableRule(typeof(global::FourDeep.PDizzle.CompartmentItemAddRule));
			ruleManager.DisableRule(typeof(global::FourDeep.PDizzle.CompartmentItemDeleteRule));
			ruleManager.DisableRule(typeof(global::FourDeep.PDizzle.CompartmentItemRolePlayerChangeRule));
			ruleManager.DisableRule(typeof(global::FourDeep.PDizzle.CompartmentItemRolePlayerPositionChangeRule));
			ruleManager.DisableRule(typeof(global::FourDeep.PDizzle.CompartmentItemChangeRule));
		}
		#endregion
	}
		
	#region Copy/Remove closure classes
	/// <summary>
	/// Remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class PDizzleDeleteClosure : PDizzleDeleteClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public PDizzleDeleteClosure() : base()
		{
		}
	}
	
	/// <summary>
	/// Base class for remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class PDizzleDeleteClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public PDizzleDeleteClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::FourDeep.PDizzle.AggregateModelHasAggregateRoot.ElementDomainRoleId, true);
			DomainRoles.Add(global::FourDeep.PDizzle.AggregateModelHasDomainCommands.DomainCommandDomainRoleId, true);
			DomainRoles.Add(global::FourDeep.PDizzle.AggregateModelHasProperties.PropertyDomainRoleId, true);
			DomainRoles.Add(global::FourDeep.PDizzle.AggregateModelHasViews.ViewDomainRoleId, true);
			DomainRoles.Add(global::FourDeep.PDizzle.AggregateModelHandlesDomainEvents.DomainEventDomainRoleId, true);
			DomainRoles.Add(global::FourDeep.PDizzle.AggregateModelHasEntities.EntityDomainRoleId, true);
			DomainRoles.Add(global::FourDeep.PDizzle.DomainCommandHasProperties.PropertyDomainRoleId, true);
			DomainRoles.Add(global::FourDeep.PDizzle.ViewHasProperties.PropertyDomainRoleId, true);
			DomainRoles.Add(global::FourDeep.PDizzle.ViewHandlesDomainEvents.DomainEventDomainRoleId, true);
			DomainRoles.Add(global::FourDeep.PDizzle.DomainEventHasProperties.PropertyDomainRoleId, true);
			DomainRoles.Add(global::FourDeep.PDizzle.EntityHasProperties.PropertyDomainRoleId, true);
			DomainRoles.Add(global::FourDeep.PDizzle.AggregateRootHasProperties.PropertyDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return DslModeling::VisitorFilterResult.Yes;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			if (targetDomainRole == null) throw new global::System.ArgumentNullException("targetDomainRole");
			return this.DomainRoles.Contains(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Specialized.HybridDictionary();
				}
				return this.domainRoles;
			}
		}
	
	}
	/// <summary>
	/// Copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class PDizzleCopyClosure : PDizzleCopyClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public PDizzleCopyClosure() : base()
		{
		}
	}
	/// <summary>
	/// Base class for copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class PDizzleCopyClosureBase : DslModeling::CopyClosureFilter, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public PDizzleCopyClosureBase():base()
		{
		}
	}
	#endregion
		
}
