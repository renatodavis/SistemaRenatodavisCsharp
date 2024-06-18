import React, { useState } from 'react';
import { Link } from 'react-router-dom';

const CadastrosDropdown: React.FC = () => {
  const [isOpen, setIsOpen] = useState(false);

  const toggleCadastrosDropdown = () => {
    setIsOpen(!isOpen);
  };

  return (
    <div className="relative">
      <button
        onClick={toggleCadastrosDropdown}
        onMouseOver={() => setIsOpen(true)}
        onMouseOut={() => setIsOpen(false)}
        className="text-white focus:outline-none flex items-center"
      >
        <span>Cadastros</span>
        <svg className="w-4 h-4 ml-1" fill="none" stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
          <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M19 9l-7 7-7-7" />
        </svg>
      </button>
      {isOpen && (
        <ul className="absolute mt-0 w-48 bg-white rounded-lg shadow-lg overflow-hidden z-15">
          <li>
            <Link
              to="/cadastros/clientes"
              className="block px-4 py-2 text-gray-800 hover:bg-gray-100"
              onClick={() => setIsOpen(false)}
            >
              Cadastro de Clientes
            </Link>
          </li>
          {/* Adicione outros itens do menu aqui conforme necessário */}
        </ul>
      )}
    </div>
  );
};

export default CadastrosDropdown;
