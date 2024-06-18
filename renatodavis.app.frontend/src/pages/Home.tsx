import React from 'react';
import MainContent from '../components/MainContent';

const Home: React.FC = () => {
  return (
    <MainContent>
      <h1 className="text-2xl font-bold">Bem-vindo ao Sistema ERP</h1>
      <p className="mt-4">Este é o conteúdo da página inicial.</p>
    </MainContent>
  );
};

export default Home;
