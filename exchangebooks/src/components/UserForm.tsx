import { useState, useEffect } from 'react';
import { Button, Card, Container } from 'react-bootstrap';
import FloatingLabel from 'react-bootstrap/FloatingLabel';
import Form from 'react-bootstrap/Form';
import { useNavigate } from 'react-router-dom';
import { NewUser, User } from '../App';

interface UserFormProps {
  users: User[];
  onFormSubmit: (user: NewUser) => void;
}

const UserForm = ({ users, onFormSubmit }: UserFormProps) => {

  const [user, setUser] = useState({
    name: '',
    email: '',
  })
  const { name, email } = user;

  const navigate = useNavigate();

  const handleOnClick = (id: number) => {
    navigate(`/users/${id}/books`);
  }
  
  useEffect(() => {
    setUser({ ...user })
  }, [])

  const handleFormSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    onFormSubmit(user);
  }
  return (
    <Container>
      {users.map((user) => {
        return (
          <Card className='mt-4' key={user.id}>
            <Card.Body>
              <Card.Title>{user.name}</Card.Title>
              <Card.Text>{user.email}</Card.Text>
              <Button onClick={() => handleOnClick(user.id)} variant="primary">See books</Button>
            </Card.Body>
          </Card>
        )
      })}
      <h1>Add new user</h1>
      <form onSubmit={handleFormSubmit}>
        <FloatingLabel controlId="floatingPassword" label="Name">
          <Form.Control value={name} onChange={e => setUser({ ...user, name: e.target.value })} type="text" placeholder="your name" />
        </FloatingLabel>
        <FloatingLabel
          controlId="floatingInput"
          label="Email address"
          className="mb-3"
        >
          <Form.Control value={email} onChange={e => setUser({ ...user, email: e.target.value })} type="email" placeholder="name@example.com" />
        </FloatingLabel>
        <Button variant="primary" type="submit">
          Submit
        </Button>
      </form>
    </Container>
  )
}

export default UserForm