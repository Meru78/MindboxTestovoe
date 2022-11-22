select * from products p
left join category_products cp on cp."ProductId" = p."CategoryId"  
left join category c on c.id = cp."CategoryId" 