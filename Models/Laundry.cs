using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Loundry.Models
{
    public class Laundry
    {
        public string ToString(day_of_week[] days)
        {
            string result = null;
            foreach(var e in days)
            {
                result += e.ToString()+" ; ";
            }
            return result; 
        }
        public enum day_of_week
        {
            [PgName("Понедельник")]
            Monday,
            [PgName("Вторник")]
            Tuesday,
            [PgName("Среда")]
            Wednesday,
            [PgName("Четверг")]
            Thursday,
            [PgName("Пятница")]
            Friday,
            [PgName("Суббота")]
            Saturday,
            [PgName("Воскресенье")]
            Sunday
        }
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("title",TypeName ="varchar(255)")]
        [StringLength(255)]
        public string LaundryName { get; set; }

        [Column("number")]
        public int MashinesMaxCount { get; set; }

        [Column("start_time",TypeName="TIME")]
        public TimeSpan StartTime {get; set; }
        
        [Column("end_time", TypeName = "TIME")]
        public TimeSpan EndTime { get; set; }

        [Column("work_day")]
        public day_of_week[] WorkDay { get; set; }

    }
}
