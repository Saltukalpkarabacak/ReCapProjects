using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CardManager : ICardService
    {
        ICardDal _cardDal;
        public CardManager(ICardDal cardDal)
        {
            _cardDal = cardDal;
        }

        public IResult Add(Card card)
        {
            _cardDal.Add(card);
            return new SuccessResult();
        }

        public IResult Delete(Card card)
        {
            _cardDal.Delete(card);
            return new SuccessResult();
        }

        public IDataResult<List<Card>> GetAll()
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetAll());
        }

        public IDataResult<List<Card>> GetByCardNumber(string cardNumber)
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetAll(c => c.CardNo == cardNumber));
        }

        public IDataResult<Card> GetById(int cardId)
        {
            return new SuccessDataResult<Card>(_cardDal.Get(c => c.Id == cardId));
        }

        public IResult IsCardExist(Card card)
        {
            var result = _cardDal.Get(c => c.Name == card.Name && c.CardNo == card.CardNo && c.Cvv == card.Cvv);
            if (result == null)
            {
                return new ErrorReslut();
            }
            return new SuccessResult();
        }

        public IResult Update(Card card)
        {
            _cardDal.Update(card);
            return new SuccessResult();
        }
    }
}
