import axios from 'axios';
import { useEffect, useState } from 'react';
import { Navbar, Container, Nav } from 'react-bootstrap';
import { Route, Routes } from 'react-router-dom';
import './App.css';
import BookDetails from './components/BookDetails';
import BookForm from './components/BookForm';
import Main from './components/main/Main';
import UserForm from './components/UserForm';
import 'bootstrap/dist/css/bootstrap.min.css';
import BooksPerUser from './components/BooksPerUser';

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
  }

  async function getUsers() {
    const response = await client.get('/Users');
    setUsers(response.data);
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
    <div className='App'>
      <Navbar className='nav-bar' bg="light" variant="light">
        <Container>
          <Navbar.Brand>Logo</Navbar.Brand>
          <Nav className="me-auto">
            <Nav.Link href="/">Home</Nav.Link>
            <Nav.Link href="/books">Books</Nav.Link>
            <Nav.Link href="/users">Users</Nav.Link>
          </Nav>
        </Container>
      </Navbar>      
        <Routes>
          <Route path="/" element={ <Main books={books} /> } />
          <Route path="books" element={ <BookForm onFormSubmit={saveBook} /> } />
          <Route path="users" element={ <UserForm users={users} onFormSubmit={saveUser} /> } />
          <Route path='users/:id/books' element={<BooksPerUser books={books} users={users} />} />
          <Route path='books/:id' element={ <BookDetails books={books} users={users} />} />
        </Routes>
    </div>
  );
}

export default App;
