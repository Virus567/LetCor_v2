
import "bootstrap/dist/css/bootstrap.min.css";
import "../assets/css/index.css";
import { useSelector} from "react-redux";
import { RootState} from "../redux/store";
import React from 'react';

export default function Home()
{
    const user = useSelector((state: RootState) => state);

    return(
        <>
        </>
    );
}