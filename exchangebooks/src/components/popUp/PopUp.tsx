interface PopUpProps {
  content: any;
  handleClose: () => void;
}

const PopUp = (content: PopUpProps) => {
  return (
    <div className="popup-box">
      <div className="box">
        <h3 className="close-icon" onClick={content.handleClose}>Request is pending</h3>
        {content.content}
      </div>
    </div>
  )
}

export default PopUp