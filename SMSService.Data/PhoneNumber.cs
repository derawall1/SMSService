﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSService.Data
{
    [Table("phone_number")]
    public class PhoneNumber
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("number")]
        public string Number { get; set; } = string.Empty;

        [Column("account_id")]
        public int AccountId { get; set; }

        // [ForeignKey("account_id")]
        public Account Account { get; set; } =new Account();
    }
}
