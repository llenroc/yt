using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp;
using Abp.Domain.Entities;

namespace YT.Storage
{
    /// <summary>
    /// �ļ��洢
    /// </summary>
    [Table("yt_objectstorage")]
    public sealed class BinaryObject : Entity<Guid>
    {
        /// <summary>
        /// �ļ�·��
        /// </summary>
        [Required]
        public string Url { get; set; }

        public BinaryObject()
        {
            Id = SequentialGuidGenerator.Instance.Create();
        }

        public BinaryObject(Guid id, string url)
        {
            Id = id;
            Url = url;
        }

        public BinaryObject(string url)
            : this()
        {
            Url = url;
        }
    }
}