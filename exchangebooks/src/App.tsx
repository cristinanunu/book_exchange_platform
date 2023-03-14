import axios from 'axios';
import { useEffect, useState } from 'react';
import './App.css';
import Books from './components/Books';
import Main from './components/Main';
import UserForm from './components/UserForm';

export interface Book {
  id: number;
  name: string;
  category: string;
  imageUrl: string;
  addedAt: string;
  user: User;
}

export interface NewBook {
  name: string;
  category: string;
  imageUrl: string;
  addedAt: string;
  // user: User,
}

export interface User {
  id: number;
  name: string;
  email: string;
}

export interface NewUser {
  name: string;
  email: string;
}


function App() {
  const [books, setBooks] = useState<Book[]>([]);
  const [users, setUsers] = useState<User[]>([])

  const client = axios.create({
    baseURL: 'http://localhost:5225/api'
  });

  async function getBooks() {
    const response = await client.get('/Books');
    setBooks(response.data);
    // let data = Array.from(response.data)
    console.log("that is the response data", response.data)
    console.log("that is the books", books)
  }

  async function getUsers() {
    const response = await client.get('/Users');
    setUsers(response.data);
    // let data = Array.from(response.data)
    //   console.log("that is the response", response.data)
    //   console.log("that is the books", users)
  }

  const saveBook = async (book: NewBook) => {
    await postBook(book);
  }

  async function postBook(book: NewBook) {
    try {
      const response = await client.post('/Books', book)
      const bookData = response.data;
      setBooks([...books, bookData])
    } catch (error) {
      throw new Error('The request to add a new book was not successful. Try again.');
    }
  }

  const saveUser = async (user: NewUser) => {
    await postUser(user);
  }

  async function postUser(user: NewUser) {
    try {
      const response = await client.post('/Users', user)
      const userData = response.data;
      setUsers([...users, userData])
    } catch (error) {
      throw new Error('The request to add a new user was not successful. Try again.');
    }
  }

  useEffect(() => {
    getBooks();
    getUsers();
  }, []);

  return (
    <>
      <p>Hello world</p>

      {books.map((book) => {
        return (
          <div key={book.id}>
            <h3>{book.name}</h3>
            <p>{book.category}</p>
            <p>{book.addedAt}</p>
            <img src={book.imageUrl} alt="books" />
          </div>
        )
      })}
      <div>
        {users.map((user) => {
          return (
            <div>
              <h3>{user.name}</h3>
              <p>{user.email}</p>
            </div>
          )
        })}
      </div>
      <Main books={books} />
      <Books books={books} onFormSubmit={saveBook} />
      <UserForm onFormSubmit={saveUser} />
    </>
  );
}

export default App;
