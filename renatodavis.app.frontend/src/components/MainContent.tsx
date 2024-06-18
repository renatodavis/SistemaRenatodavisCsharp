import React from 'react';

const MainContent: React.FC = ({ children }) => {
  return (
    <main className="flex-1 p-4">
      {children}
    </main>
  );
};

export default MainContent;