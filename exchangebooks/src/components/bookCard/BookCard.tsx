import Button from 'react-bootstrap/Button';
import Card from 'react-bootstrap/Card';
import { useNavigate } from 'react-router-dom';
import { Book, User } from '../../App';
import Style from './BookCard.module.css'
import moment from 'moment';

interface BookCardProps {
  book: Book;
  user: User;
}

function BookCard({ book }: BookCardProps) {
  const navigate = useNavigate();

  const handleOnClick = (id: number) => {
    navigate(`/books/${id}`);
  }

  return (
      <Card className='mt-4' style={{ width: '350px', boxShadow: "4px 3px 2px #9E9E9E" }}>
        <div>
          <Card.Img style={{ height: '500px' }} variant="top" src={book.imageUrl} />
          <Card.Body>
            <Card.Title className={Style.title}>{book.name}</Card.Title>
            <Card.Text>
              Category: {book.category}
            </Card.Text>
            <Card.Text>
              Added on: {moment(book.addedAt).format('MMM Do YY')}
            </Card.Text>
            <Button onClick={() => handleOnClick(book.id)} variant="primary">See details</Button>
          </Card.Body>
        </div>
      </Card>
  )
}
export default BookCard