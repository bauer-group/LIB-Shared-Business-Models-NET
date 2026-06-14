using System;
using BAUERGROUP.Shared.Business.Models.Shipping;

namespace BAUERGROUP.Shared.Business.Models.ERP.Interfaces
{
    public interface IERPAPI: IDisposable
    {        
        IERPConfiguration Configuration { get; set; }

        #region ERPDocument
        Guid CreateDocument(ERPDocument erpDocument);
        List<ERPDocument> ReadDocument(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        void UpdateDocument(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        void DeleteDocument(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        #endregion

        #region ERPDocumentShippingInformation
        Guid CreateDocumentShippingInformation(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        List<KeyValuePair<Guid, Parcel>> ReadDocumentShippingInformation(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        void UpdateDocumentShippingInformation(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        void DeleteDocumentShippingInformation(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        #endregion

        #region ERPDocumentStatus
        KeyValuePair<Guid, ERPDocumentProcessingStatus> ReadDocumentStatus(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        void UpdateDocumentStatus(ERPDocument erpDocument, ERPDocumentFilterMode filterMode = ERPDocumentFilterMode.UID);
        #endregion

        #region ERPStockInventory
        List<Guid> CreateStockInventory(List<ERPStockInventory> erpStockInventory);
        List<ERPStockInventory> ReadStockInventory(ERPStockInventory erpStockInventory, ERPDocumentProcessingStatus eProcessingStatus = ERPDocumentProcessingStatus.Unprocessed, ERPStockInventoryFilterMode filterMode = ERPStockInventoryFilterMode.UID);
        void UpdateStockInventoryStatus(ERPStockInventory erpStockInventory, ERPDocumentProcessingStatus eProcessingStatus = ERPDocumentProcessingStatus.Unprocessed, ERPStockInventoryFilterMode filterMode = ERPStockInventoryFilterMode.UID);
        void UpdateStockInventoryStatus(List<ERPStockInventory> erpStockInventories, ERPDocumentProcessingStatus eProcessingStatus = ERPDocumentProcessingStatus.Unprocessed, ERPStockInventoryFilterMode filterMode = ERPStockInventoryFilterMode.UID);
        #endregion    
    }
}
