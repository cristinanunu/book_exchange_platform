import { useEffect, useState } from "react";
import { Col, Container, Row } from "react-bootstrap";
import { Book } from "../../App";
import BookCard from "../bookCard/BookCard";
import SearchBar from "../searchbar/SearchBar";
import Style from './Main.module.css'

interface MainProps {
  books: Book[];
}

const Main = ({ books }: MainProps) => {
  const [filterBooks, setFilterBooks] = useState(books)
  
  const handleSubmit = (value: string) => {
    const filterByCategory = books.filter(book => book.category === value);
    setFilterBooks(filterByCategory);
  }
  useEffect(() => {
    setFilterBooks(books)
  }, [books])

  return (
    <Container>
      <h1 className={Style.title}>Browse through the library</h1>
      <SearchBar sendInputValue={handleSubmit} />
      <Row>
        {filterBooks.map((book) => {
          return (
            <Col key={book.id}>
              <BookCard book={book} user={book.user} />
            </Col>
          )
        })}
      </Row>
    </Container>
    )
  }
  
  export default Main