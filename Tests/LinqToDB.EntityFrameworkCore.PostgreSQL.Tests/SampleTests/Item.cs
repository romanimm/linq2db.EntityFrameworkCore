﻿namespace LinqToDB.EntityFrameworkCore.PostgreSQL.Tests.SampleTests
{
    public sealed class Item : IHasWriteableId<Item, long>
    {
        public Id<Item, long> Id { get; set; }
        public string Name { get; set; }
    }
}
