import { Col, Container, Row } from 'react-bootstrap';
import { useParams } from 'react-router-dom'
import { Book, User } from '../App';

interface BookDetailsProps {
  books: Book[];
  users: User[];
}

const BookDetails = ({ books, users}: BookDetailsProps) => {
  const params = useParams();

  const selectedBook = books.find((book) => book.id.toString() === params.id)
  const ownerOfBook = users.find((user) => user.id === selectedBook?.user.id)
  return (
    <Container>
      <div className='m-4'>
        <Row>
          <Col>
            <img width='300px' src={selectedBook?.imageUrl} alt="cover" />
          </Col>
          <Col>
            <h1>{selectedBook?.name}</h1>
            <p>Category: {selectedBook?.category}</p>
            <p>Added on: {selectedBook?.addedAt}</p>
            
            <h3>User: {ownerOfBook?.name}</h3>
          </Col>
        </Row>
      </div>
    </Container>
  )
}

export default BookDetails