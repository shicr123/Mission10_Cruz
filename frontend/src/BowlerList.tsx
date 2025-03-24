import { useState } from 'react';
import { crew } from './types/Crew.ts';


function BowlerList() {
  const [crews, setCrew] = useState<crew[]>([]);
  const fetchCrew = async () => {
    const response = await fetch('https://localhost:5000/api/BowlerCrew');
    const data = await response.json();
    setCrew(data);
  };

  fetchCrew();

  // information about all the data 
  // this is where I am joining all the tables 

  return (
    <>
      <h1>Bowler Crew</h1>
      <table>
        <thead>
          <tr>
            <th>First Name:</th>
            <th>Middle Name:</th>
            <th>Last Name:</th>
            <th>Address:</th>
            <th>City:</th>
            <th>State:</th>
            <th>Zip:</th>
            <th>Phone Number:</th>
            <th>Team Name:</th>
          </tr>
        </thead>
        <tbody>
    
          {crews.map((b) => (
            <tr key={b.bowlerId}>
              <td>{b.bowlerFirstName}</td>
              <td>{b.bowlerMiddleInit}</td>
              <td>{b.bowlerLastName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
              <td>{b.team?.teamName}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;