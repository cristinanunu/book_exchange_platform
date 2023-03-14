import { useState, useEffect } from 'react';
import { Button } from 'react-bootstrap';
import FloatingLabel from 'react-bootstrap/FloatingLabel';
import Form from 'react-bootstrap/Form';
import { NewUser } from '../App';

interface UserFormProps {
  onFormSubmit: (user: NewUser) => void;
}

const UserForm = ({onFormSubmit}: UserFormProps) => {

  const [user, setUser] = useState({
    name: '',
    email: '',
  })
  const { name, email } = user;

  useEffect(() => {
    setUser({ ...user })
  }, [])

  const handleFormSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    onFormSubmit(user);
  }
  return (
    <>
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
    </>
  )
}

export default UserForm