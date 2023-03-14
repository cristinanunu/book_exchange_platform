import React, { useEffect, useState } from 'react'
import { Book, NewBook, User } from '../App';

interface BooksProps {
  books: Book[];
  onFormSubmit: (book: NewBook) => void;
}

const Books = ({ books, onFormSubmit }: BooksProps) => {

  const [book, setBook] = useState({
    name: '',
    category: '',
    imageUrl: '',
    addedAt: '',
  })
  const { name, category, imageUrl, addedAt } = book;

  useEffect(() => {
    setBook({ ...book })
  }, [])

  const handleFormSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    onFormSubmit(book);
  }

  return (
    <div>
      <h1>Add new book</h1>
      <form onSubmit={handleFormSubmit}>
        <label htmlFor='name'>Name:
          <input pattern='[a-zA-Z ]+' value={name} onChange={e => setBook({ ...book, name: e.target.value })} type='text' name='name' required placeholder='enter name' />
        </label>
        <label htmlFor='category'>Category:
          <input pattern='[a-zA-Z ]+' value={category} onChange={e => setBook({ ...book, category: e.target.value })} type='text' name='category' required placeholder='category' />
        </label>
        <label htmlFor='imageUrl'>Submit a url for the picture:
          <input value={imageUrl} onChange={e => setBook({ ...book, imageUrl: e.target.value })} type="url" name='imageUrl' required placeholder='imageUrl' />
        </label>
        <label htmlFor='addedAt'>Date:
          <input value={addedAt} onChange={e => setBook({ ...book, addedAt: e.target.value })} type='date' name='addedAt' required placeholder='addedAt' />
        </label>
        <div>
          <button type='submit'>Add Book</button>
        </div>
      </form>
    </div>
  )
};

export default Books