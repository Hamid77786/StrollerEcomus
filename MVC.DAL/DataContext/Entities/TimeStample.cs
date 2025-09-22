﻿;namespace StrollerEcomus.DAL.DataContext.Entities
{
    public class TimeStample:Entity
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
