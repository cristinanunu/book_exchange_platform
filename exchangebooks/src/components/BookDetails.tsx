import moment from 'moment';
import { useState } from 'react';
import { Button, Col, Container, Row } from 'react-bootstrap';
import { useNavigate, useParams } from 'react-router-dom'
import { Book, User } from '../App';
import PopUp from './popUp/PopUp'

interface BookDetailsProps {
  books: Book[];
  users: User[];
  deleteBook: (id: number) => void;
}

const BookDetails = ({ books, users, deleteBook }: BookDetailsProps) => {
  const [isOpen, setIsOpen] = useState(false);
  const [toggle, setToggle] = useState(false);

  const params = useParams();
  const navigate = useNavigate();

  const selectedBook = books.find((book) => book.id.toString() === params.id)
  const ownerOfBook = users.find((user) => user.id === selectedBook?.user.id)

  const handleDelete = (id: number) => {
    deleteBook(id);
    navigate('/users', { replace: true });
  }

  const togglePopup = () => {
    setIsOpen(!isOpen);
  }
  return (
    <Container>
      <div className='m-4'>
        <Row>
          <Col>
            <img width='300px' src={selectedBook?.imageUrl} alt="cover" />
          </Col>
          <Col>
            <div>
              <div onClick={() => setToggle(!toggle)}>
                <h1>{selectedBook?.name}</h1>
                <p>Category: {selectedBook?.category}</p>
                <p>Added on: {moment(selectedBook?.addedAt).format('MMM Do YY')}</p>
                <h3>User: {ownerOfBook?.name}</h3>
                {toggle && <Button onClick={() => handleDelete(selectedBook?.id!)}>Delete</Button>}
                <hr />
              </div>
              <div>
                <Button value="Reserve Book" onClick={togglePopup}>Reserve book</Button>
                {isOpen && <PopUp
                  content={<>
                    <p>Your request have been sent. {ownerOfBook?.name} will get in touch with you as soon as possible</p>
                  </>}
                  handleClose={togglePopup}
                />}
              </div>
            </div>
          </Col>
        </Row>
      </div>
    </Container>
  )
}

export default BookDetails
