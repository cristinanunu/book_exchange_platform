import React, { useState } from 'react'
import Styles from './SearchBar.module.css'
interface SearchBarProps {
  sendInputValue: (value: string) => void;
}

const SearchBar = ({sendInputValue}: SearchBarProps) => {
  const [inputValue, setInputValue] = useState('');
  
  const onFormSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    sendInputValue(inputValue)
  }
  return (
    <div>
      <form onSubmit={onFormSubmit} className={Styles.form}>
        <input
          placeholder="Search by category..."
          value={inputValue}
          onChange={e => setInputValue(e.target.value)}
          className={Styles.input}
        />
        <button type="submit" className={Styles.button}>Search</button>
      </form>
    </div>
  )
}

export default SearchBar