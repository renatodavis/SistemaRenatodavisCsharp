import React from 'react';
import Sidebar from '../components/Sidebar';
import MainContent from '../components/MainContent';

const Outra: React.FC = () => {
  return (
    <div className="flex">
      <Sidebar />
      <MainContent>
        <h1>Outra Página</h1>
        <p>Conteúdo principal da outra.</p>
      </MainContent>
    </div>
  );
};

export default Outra;
