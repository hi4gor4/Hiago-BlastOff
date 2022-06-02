use aula;
DELIMITER $$

	CREATE FUNCTION fn_troco ( pagamento float ,  preco float)    
	RETURNS nvarchar(40) deterministic
    begin
		declare troco float;
		declare retorno nvarchar(40);
		set  troco = pagamento-preco; 
		if troco < 0.05 then
			set retorno ='Sem troco';
		elseif troco <= 1 then
			set retorno =  'Balinhas de café';
		else 
			set retorno = 'Em dinheiro';
		end if;
		return retorno;
    end
$$