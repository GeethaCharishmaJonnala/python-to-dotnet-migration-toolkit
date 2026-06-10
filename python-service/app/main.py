from fastapi import FastAPI
from app.logger import logger

app = FastAPI()

@app.get("/")
def health_check():
    return {
        "status": "running"
    }

@app.get("/process-data")
def process_data():
    try:
        logger.info("Processing request")

        score = 95

        return {
            "status": "success",
            "source": "python",
            "data": {
                "score": score,
                "message": "Business logic executed successfully"
            }
        }

    except Exception as ex:
        logger.error(f"Processing failed: {str(ex)}")

        return {
            "status": "error",
            "message": str(ex)
        }