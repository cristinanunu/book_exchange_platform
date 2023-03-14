import { useState, useEffect } from "react";
import { Book, User } from "../App";

interface NewBook {
  name: string;
  category: string;
  url: string;
  addedAt: string;
  user: User;
}

interface IMainProps {
  books: Book[];
}

const Main = ({ books }: IMainProps) => {
  // const [developer, setDeveloper] = useState({
  //   firstName: '',
  //   lastName: '',
  //   bootcampId: '',
  // })
  // const {firstName, lastName, bootcampId} = developer;

  // // useEffect(() => {
  // //   setDeveloper({...developer, bootcampId: bootcamps[0]?.id})
  // // }, [bootcamps[0]?.id])

  // // const handleFormSubmit = (e: React.FormEvent<HTMLFormElement>) => {
  // //   e.preventDefault();
  // //   onFormSubmit(developer);
  // // }
  // const booksData = [];
  return (
    <div>
      {/* {books.map((book) => {
      <h3>{book.name}</h3>
      
    })} */}
    </div>
    )
  }
  
  export default Main