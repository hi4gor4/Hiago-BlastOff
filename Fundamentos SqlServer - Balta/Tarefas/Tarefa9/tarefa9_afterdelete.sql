create trigger tr_after_delete before delete
on itens_venda
for each ROW
update produto
	set estoque = estoque + itens_venda.quantidade
 where
	id = itens_venda.id_produto