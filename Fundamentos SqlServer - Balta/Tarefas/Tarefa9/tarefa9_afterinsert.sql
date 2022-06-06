create trigger tr_after_insert before insert
on itens_venda
for each ROW
update produto
	set estoque = estoque - new.quantidade
 where
	id = itens_venda.id_produto