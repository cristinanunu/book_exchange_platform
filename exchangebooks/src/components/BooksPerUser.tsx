import React from 'react'
import { Col, Container, Row } from 'react-bootstrap';
import { useParams } from 'react-router-dom';
import { Book, User } from '../App';
import BookCard from './bookCard/BookCard';

interface BooksPerUserProps {
  books: Book[];
  users: User[];
}

const BooksPerUser = ({ books, users}: BooksPerUserProps) => {
  const params = useParams();
  console.log("books", books)
  console.log("users", users)

  //const userById = users.find((user) => user.id.toString() === params.id);
  const filterBooksPerUser = books.filter((book) => book.user && book.user.id.toString() === params.id)
  
  return (
    <Container>
      <Row>
        {filterBooksPerUser.map((book) => ( 
          <Col>
            <BookCard book={book} />
          </Col>
        ))}
      </Row>
    </Container>
  )
}

export default BooksPerUser