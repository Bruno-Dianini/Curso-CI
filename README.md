Na imagem 001 - Resolvemos dividir os program em partes, para que o "program." ficasse com o codigo mais limpo, dividimos em "Usuario", "Pessoas" e "Agendamento".

Na imagem 002  - Criamos o "Usuario " e uma classe public para ter acesso no progra principal - foi definido como: nome , e-mail e id. Estes seriam os dados nescessarios para o agendamento no sistema.

na imagem 003 - criamos a classe "Pessoas" para que ela tivesse ligacao de heranca com o "Usuario" e para a classe "Pessoa" criamos apenas o "colaborador" para perguntar se seria um professor ou coodernador que faria o agendamento.

na imagem 004 -  criamos a classe "Agendamento" e estruturamos para que gere um erro se por um acaso for digitado uma data errada, e achamos mais coerente que o colaborador escolhesse qual material que ele estaria agendando. E caso seja mais de um mateial o program perguntara novamente, caso contrario sera usado apenas  um "sair" para o usuario.