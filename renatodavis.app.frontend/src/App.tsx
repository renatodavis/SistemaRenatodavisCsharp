import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Home from './pages/Home';
import Outra from './pages/Outra';
import CadastroClientes from './pages/CadastroClientes';
import Header from './components/Header';

const App: React.FC = () => {
  return (
    <Router>
      <Header />
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/CadastroClientes" element={<CadastroClientes />} />
        <Route path="/Outra" element={<Outra/>} />
      </Routes>
    </Router>
  );
};

export default App;
