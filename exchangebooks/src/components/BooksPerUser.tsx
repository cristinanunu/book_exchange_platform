import { Col, Container, Row } from 'react-bootstrap';
import { useParams } from 'react-router-dom';
import { Book } from '../App';
import BookCard from './bookCard/BookCard';

interface BooksPerUserProps {
  books: Book[];
}

const BooksPerUser = ({ books }: BooksPerUserProps) => {
  const params = useParams();
  const filterBooksPerUser = books.filter((book) => book.user && book.user.id.toString() === params.id) 
  
  return (
    <Container>
      <Row>
        {filterBooksPerUser.map((book) => ( 
          <Col>
            <BookCard book={book} user={book.user} />
          </Col>
        ))}
      </Row>
    </Container>
  )
}

export default BooksPerUser