import Button from 'react-bootstrap/Button';
import Card from 'react-bootstrap/Card';
import { useNavigate } from 'react-router-dom';
import { Book, User } from '../../App';
import BookDetails from '../BookDetails';
import Style from './BookCard.module.css'


interface BookCardProps {
  book: Book;
}

function BookCard({ book }: BookCardProps) {

  const navigate = useNavigate();

  const handleOnClick = (id: number) => {
    navigate(`/books/${id}`);
  }

  return (
      <Card className='mt-4' style={{ width: '350px' }}>
        <div>
          <Card.Img style={{ height: '500px' }} variant="top" src={book.imageUrl} />
          <Card.Body>
            <Card.Title className={Style.title}>{book.name}</Card.Title>
            <Card.Text>
              {book.category}
              
            </Card.Text>
            <Card.Text>
              
              {book.addedAt}
            </Card.Text>
            <Button onClick={() => handleOnClick(book.id)} variant="primary">See details</Button>
          </Card.Body>
        </div>
      </Card>
  )
}
export default BookCard;