using System;
using BAUERGROUP.Shared.Business.Models.Shipping;

namespace BAUERGROUP.Shared.Business.Models.ERP.Interfaces
{
    /// <summary>
    /// Service contract for an ERP backend. Provides CRUD operations over ERP documents, their
    /// shipping information and processing status, and stock inventory. Implements
    /// <see cref="IDisposable"/> so the underlying connection can be released.
    /// </summary>
    public interface IERPAPI: IDisposable
    {
        /// <summary>Configuration settings used by this ERP service instance.</summary>
        IERPConfiguration Configuration { get; set; }

        #region ERPDocument
        /// <summary>Creates a new ERP document.</summary>
        /// <param name="erpDocument">The document to create.</param>
        /// <returns>The identifier of the created document.</returns>
        Guid CreateDocument(ERPDocument erpDocument);
        /// <summary>Reads ERP documents matching the supplied filter.</summary>
        /// <param name="erpDocument">Document carrying the filter criteria.</param>
        /// <param name="filterMode">Field on which to match (defaults to <see cref="ERPDocumentFilterMode.UID"/>).</param>
        /// <returns>The matching documents.</returns>
        List<ERPDocument> ReadDocument(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        /// <summary>Updates an existing ERP document.</summary>
        /// <param name="erpDocument">The document carrying the new values.</param>
        /// <param name="filterMode">Field on which to locate the target (defaults to <see cref="ERPDocumentFilterMode.UID"/>).</param>
        void UpdateDocument(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        /// <summary>Deletes an ERP document.</summary>
        /// <param name="erpDocument">Document carrying the criteria identifying what to delete.</param>
        /// <param name="filterMode">Field on which to locate the target (defaults to <see cref="ERPDocumentFilterMode.UID"/>).</param>
        void DeleteDocument(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        #endregion

        #region ERPDocumentShippingInformation
        /// <summary>Creates the shipping information attached to an ERP document.</summary>
        /// <param name="erpDocument">The document to attach shipping information to.</param>
        /// <param name="filterMode">Field on which to locate the document (defaults to <see cref="ERPDocumentFilterMode.UID"/>).</param>
        /// <returns>The identifier of the created shipping information.</returns>
        Guid CreateDocumentShippingInformation(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        /// <summary>Reads the shipping information for an ERP document.</summary>
        /// <param name="erpDocument">Document carrying the filter criteria.</param>
        /// <param name="filterMode">Field on which to match (defaults to <see cref="ERPDocumentFilterMode.UID"/>).</param>
        /// <returns>Parcels keyed by their identifier.</returns>
        List<KeyValuePair<Guid, Parcel>> ReadDocumentShippingInformation(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        /// <summary>Updates the shipping information of an ERP document.</summary>
        /// <param name="erpDocument">The document carrying the new shipping information.</param>
        /// <param name="filterMode">Field on which to locate the document (defaults to <see cref="ERPDocumentFilterMode.UID"/>).</param>
        void UpdateDocumentShippingInformation(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        /// <summary>Deletes the shipping information of an ERP document.</summary>
        /// <param name="erpDocument">Document carrying the criteria identifying the shipping information.</param>
        /// <param name="filterMode">Field on which to locate the document (defaults to <see cref="ERPDocumentFilterMode.UID"/>).</param>
        void DeleteDocumentShippingInformation(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        #endregion

        #region ERPDocumentStatus
        /// <summary>Reads the processing status of an ERP document.</summary>
        /// <param name="erpDocument">Document carrying the filter criteria.</param>
        /// <param name="filterMode">Field on which to match (defaults to <see cref="ERPDocumentFilterMode.UID"/>).</param>
        /// <returns>The document identifier paired with its <see cref="ERPDocumentProcessingStatus"/>.</returns>
        KeyValuePair<Guid, ERPDocumentProcessingStatus> ReadDocumentStatus(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        /// <summary>Updates the processing status of an ERP document.</summary>
        /// <param name="erpDocument">The document carrying the new status.</param>
        /// <param name="filterMode">Field on which to locate the document (defaults to <see cref="ERPDocumentFilterMode.UID"/>).</param>
        void UpdateDocumentStatus(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        #endregion

        #region ERPStockInventory
        /// <summary>Creates one or more stock inventory records.</summary>
        /// <param name="erpStockInventory">The inventory records to create.</param>
        /// <returns>The identifiers of the created records.</returns>
        List<Guid> CreateStockInventory(List<ERPStockInventory> erpStockInventory);
        /// <summary>Reads stock inventory records matching the supplied criteria.</summary>
        /// <param name="erpStockInventory">Inventory record carrying the filter criteria.</param>
        /// <param name="eProcessingStatus">Processing status to filter by (defaults to <see cref="ERPDocumentProcessingStatus.Unprocessed"/>).</param>
        /// <param name="filterMode">Field on which to match (defaults to <see cref="ERPStockInventoryFilterMode.UID"/>).</param>
        /// <returns>The matching inventory records.</returns>
        List<ERPStockInventory> ReadStockInventory(ERPStockInventory erpStockInventory, ERPDocumentProcessingStatus eProcessingStatus = ERPDocumentProcessingStatus.Unprocessed, ERPStockInventoryFilterMode filterMode = ERPStockInventoryFilterMode.UID);
        /// <summary>Updates the processing status of a single stock inventory record.</summary>
        /// <param name="erpStockInventory">Inventory record identifying the target.</param>
        /// <param name="eProcessingStatus">New processing status to set (defaults to <see cref="ERPDocumentProcessingStatus.Unprocessed"/>).</param>
        /// <param name="filterMode">Field on which to locate the record (defaults to <see cref="ERPStockInventoryFilterMode.UID"/>).</param>
        void UpdateStockInventoryStatus(ERPStockInventory erpStockInventory, ERPDocumentProcessingStatus eProcessingStatus = ERPDocumentProcessingStatus.Unprocessed, ERPStockInventoryFilterMode filterMode = ERPStockInventoryFilterMode.UID);
        /// <summary>Updates the processing status of multiple stock inventory records.</summary>
        /// <param name="erpStockInventories">Inventory records identifying the targets.</param>
        /// <param name="eProcessingStatus">New processing status to set (defaults to <see cref="ERPDocumentProcessingStatus.Unprocessed"/>).</param>
        /// <param name="filterMode">Field on which to locate the records (defaults to <see cref="ERPStockInventoryFilterMode.UID"/>).</param>
        void UpdateStockInventoryStatus(List<ERPStockInventory> erpStockInventories, ERPDocumentProcessingStatus eProcessingStatus = ERPDocumentProcessingStatus.Unprocessed, ERPStockInventoryFilterMode filterMode = ERPStockInventoryFilterMode.UID);
        #endregion
    }
}
