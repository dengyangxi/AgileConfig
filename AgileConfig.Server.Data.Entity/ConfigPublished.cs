﻿using FreeSql.DataAnnotations;
using System;

namespace AgileConfig.Server.Data.Entity
{
    [Table(Name = "agc_config_published")]
    public class ConfigPublished
    {
        [Column(Name = "id", StringLength = 36)]
        public string Id { get; set; }

        [Column(Name = "app_id", StringLength = 36)]
        public string AppId { get; set; }

        [Column(Name = "g", StringLength = 100)]
        public string Group { get; set; }

        [Column(Name = "k", StringLength = 100)]
        public string Key { get; set; }

        public string Value { get; set; }

        [Column(Name = "publish_time")]
        public DateTime? PublishTime { get; set; }

        [Column(Name = "config_id", StringLength = 36)]
        public string ConfigId { get; set; }

        [Column(Name = "publish_user_id", StringLength = 36)]
        public string PublishUserId { get; set; }

    }
}
