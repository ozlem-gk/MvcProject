﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Content
    {
        [Key]
        public int ContenID { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }
        //Content yazar
        //Content baslik 

        //Connection with heading
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }


        public int WriterID { get; set; }
        public virtual Writer Writers { get; set; }

        
    }
}
