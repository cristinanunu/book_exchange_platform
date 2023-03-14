import { useEffect, useState } from "react";
import { Col, Container, Row } from "react-bootstrap";
import { Book, User } from "../../App";
import BookCard from "../bookCard/BookCard";
import SearchBar from "../searchbar/SearchBar";
// import { useNavigate } from 'react-router-dom';

// interface NewBook {
//   name: string;
//   category: string;
//   url: string;
//   addedAt: string;
//   user: User;
// }

interface MainProps {
  books: Book[];
}

const Main = ({ books }: MainProps) => {
  const [filterBooks, setFilterBooks] = useState(books)
  console.log("books", books)
  console.log("that is filtered books", filterBooks)
  
  const handleSubmit = (value: string) => {
    console.log("that is it", value)
    const filterByCategory = books.filter(book => book.category === value);
    setFilterBooks(filterByCategory);
  }
  useEffect(() => {
    setFilterBooks(books)
    console.log("update state from useeffect", books)
  }, [books])

  return (
    <Container>
      <h1>Browse through the library</h1>
      <SearchBar sendInputValue={handleSubmit} />
      <Row>
        {filterBooks.map((book) => {
          return (
            <Col key={book.id}>
              <BookCard book={book} />
            </Col>

          )
        })}

      </Row>
    </Container>
    )
  }
  
  export default Main