import React, { useState } from 'react';

interface SidebarProps {
  title: string;
  filters: { id: number; label: string }[];
}

const Sidebar: React.FC<SidebarProps> = ({ title, filters }) => {
  const [activeFilter, setActiveFilter] = useState<number | null>(null);

  const handleFilterClick = (id: number) => {
    setActiveFilter(id === activeFilter ? null : id);
  };

  return (
    <aside className="bg-gray-200 p-4">
      <div>
        <h3 className="text-lg font-semibold mb-4">{title}</h3>
        <ul>
          {filters.map((filter) => (
            <li key={filter.id} className="mb-2">
              <button
                className={`w-full text-left px-2 py-1 rounded-md ${activeFilter === filter.id ? 'bg-blue-500 text-white' : 'hover:bg-gray-300'}`}
                onClick={() => handleFilterClick(filter.id)}
              >
                {filter.label}
              </button>
            </li>
          ))}
        </ul>
      </div>
    </aside>
  );
};

export default Sidebar;
