using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.WindowsAzure.Mobile.Service.Tables;
using Motip.Resources.Model;

namespace Motip.Web.AzureMobileService.DataObjects
{
    public class Place : PlaceData, ITableData
    {
        #region System
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Index(IsClustered = true)]
        [TableColumn(TableColumnType.CreatedAt)]
        public DateTimeOffset? CreatedAt { get; set; }
        [TableColumn(TableColumnType.Deleted)]
        public bool Deleted { get; set; }
        [Key]
        [TableColumn(TableColumnType.Id)]
        public string Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [TableColumn(TableColumnType.UpdatedAt)]
        public DateTimeOffset? UpdatedAt { get; set; }
        [TableColumn(TableColumnType.Version)]
        [Timestamp]
        public byte[] Version { get; set; }
        #endregion
    }
}
