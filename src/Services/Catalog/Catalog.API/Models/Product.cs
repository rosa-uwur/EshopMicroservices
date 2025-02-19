
﻿using System;

public class Product
{

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } = default!;
    public List<string> Category { get; set; }
    public string ImageFile { get; set; }
    public decimal Price { get; set; }
}


﻿namespace Catalog.API.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = default!;
        public List<string> Category { get; set; }
        public string ImageFile { get; set; }
        public decimal Price { get; set; }



    }

}
