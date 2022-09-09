﻿namespace CoffeeShop.Domain.Entities.MtM_IntermediateEntities;

public class DiscountCoffee
{
    public long DiscountId { get; set; }
    public virtual Discount? Discount { get; set; }
    
    public long CoffeeId { get; set; }
    public virtual Coffee? Coffee { get; set; }
}