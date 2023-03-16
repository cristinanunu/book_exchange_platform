import React, { useEffect, useState } from 'react'
import { NewBook } from '../App';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import { Container } from 'react-bootstrap';

interface BooksProps {
  onFormSubmit: (book: NewBook) => void;
}

const BookForm = ({ onFormSubmit }: BooksProps) => {
  const [book, setBook] = useState({
    name: '',
    category: '',
    imageUrl: '',
    addedAt: '',
  })
  const { name, category, imageUrl, addedAt } = book;

  useEffect(() => {
    setBook({
      name: '',
      category: '',
      imageUrl: '',
      addedAt: '',
    })
  }, [])

  const handleFormSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    onFormSubmit(book);
    setBook({
      name: '',
      category: '',
      imageUrl: '',
      addedAt: '',
    })
  }

  return (
    <Container>
      <h1>Add new book to your list</h1>
      <Form onSubmit={handleFormSubmit}>
        <Form.Group className="mb-3" controlId="formBasicEmail">
          <Form.Label>Name:</Form.Label>
          <Form.Control pattern='[a-zA-Z ]+' value={name} onChange={e => setBook({ ...book, name: e.target.value })} type="text" placeholder="Enter your name..." />
        </Form.Group>

        <Form.Group className="mb-3" controlId="formBasicEmail">
          <Form.Label>Category:</Form.Label>
          <Form.Control pattern='[a-zA-Z ]+' value={category} onChange={e => setBook({ ...book, category: e.target.value })} type="text" placeholder="Category..." />
        </Form.Group>

        <Form.Group className="mb-3" controlId="formBasicEmail">
          <Form.Label>Submit a url for the picture:</Form.Label>
          <Form.Control value={imageUrl} onChange={e => setBook({ ...book, imageUrl: e.target.value })} type="url" placeholder="Image link..." />
        </Form.Group>

        <Form.Group className="mb-3" controlId="formBasicEmail">
          <Form.Label>Date:</Form.Label>
          <Form.Control value={addedAt} onChange={e => setBook({ ...book, addedAt: e.target.value })} type="date" placeholder="Category..." />
        </Form.Group>

        <Button variant="primary" type="submit">
        Add Book
        </Button>
      </Form>
    </Container>
  )
};

export default BookForm