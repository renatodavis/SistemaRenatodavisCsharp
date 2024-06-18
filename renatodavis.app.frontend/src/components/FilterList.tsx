import React from 'react';

interface Filter {
  id: number;
  label: string;
  checked: boolean;
}

interface FilterListProps {
  filters: Filter[];
  onFilterChange: (id: number) => void;
}

const FilterList: React.FC<FilterListProps> = ({ filters, onFilterChange }) => {
  return (
    <div>
      <h3 className="mb-4 font-bold">Filtros</h3>
      <ul>
        {filters.map((filter) => (
          <li key={filter.id} className="mb-2">
            <label className="flex items-center">
              <input
                type="checkbox"
                className="mr-2"
                checked={filter.checked}
                onChange={() => onFilterChange(filter.id)}
              />
              {filter.label}
            </label>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default FilterList;
