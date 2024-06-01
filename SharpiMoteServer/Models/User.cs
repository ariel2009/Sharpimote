using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharpiMoteServer.Models
{
    internal class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public Guid CLIENT_ID { get; set; }
        public string IP_ADDR { get; set; }
        public string CODE { get; set; }
        public byte[] HASH { get; set; }
    }
}
