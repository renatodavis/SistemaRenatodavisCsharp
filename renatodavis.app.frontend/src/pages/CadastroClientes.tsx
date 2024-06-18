import React from 'react';
import MainContent from '../components/MainContent';

const CadastroClientes: React.FC = () => {
  const filters = [
    { id: 1, label: 'Filtro 1' },
    { id: 2, label: 'Filtro 2' },
    { id: 3, label: 'Filtro 3' },
  ];

  return (
    <MainContent>
      <h1 className="text-2xl font-bold">Bem-vindo ao Sistema ERP</h1>
      <p className="mt-4">Este é o conteúdo do cadastro de clientes.</p>
    </MainContent>
  );
};

export default CadastroClientes;
