(set-logic HORN)
(set-option :produce-proofs true)
(declare-datatypes ((Nat_0 0)) (((Z_0 ) (S_0 (unS_0 Nat_0)))))
(declare-fun diseqNat_0 (Nat_0 Nat_0) Bool)
(declare-fun unS_1 (Nat_0 Nat_0) Bool)
(declare-fun isZ_0 (Nat_0) Bool)
(declare-fun isS_0 (Nat_0) Bool)
(assert (forall ((x_19 Nat_0) (x_18 Nat_0))
	(=> (= x_19 (S_0 x_18))
	    (unS_1 x_18 x_19))))
(assert (isZ_0 Z_0))
(assert (forall ((x_20 Nat_0))
	(isS_0 (S_0 x_20))))
(assert (forall ((x_21 Nat_0))
	(diseqNat_0 Z_0 (S_0 x_21))))
(assert (forall ((x_22 Nat_0))
	(diseqNat_0 (S_0 x_22) Z_0)))
(assert (forall ((x_23 Nat_0) (x_24 Nat_0))
	(=> (diseqNat_0 x_23 x_24)
	    (diseqNat_0 (S_0 x_23) (S_0 x_24)))))
(declare-fun add_0 (Nat_0 Nat_0 Nat_0) Bool)
(declare-fun minus_0 (Nat_0 Nat_0 Nat_0) Bool)
(declare-fun le_0 (Nat_0 Nat_0) Bool)
(declare-fun ge_0 (Nat_0 Nat_0) Bool)
(declare-fun lt_0 (Nat_0 Nat_0) Bool)
(declare-fun gt_0 (Nat_0 Nat_0) Bool)
(declare-fun mult_0 (Nat_0 Nat_0 Nat_0) Bool)
(declare-fun div_0 (Nat_0 Nat_0 Nat_0) Bool)
(declare-fun mod_0 (Nat_0 Nat_0 Nat_0) Bool)
(assert (forall ((y_0 Nat_0))
	(add_0 y_0 Z_0 y_0)))
(assert (forall ((x_16 Nat_0) (y_0 Nat_0) (r_0 Nat_0))
	(=> (add_0 r_0 x_16 y_0)
	    (add_0 (S_0 r_0) (S_0 x_16) y_0))))
(assert (forall ((y_0 Nat_0))
	(minus_0 Z_0 Z_0 y_0)))
(assert (forall ((x_16 Nat_0) (y_0 Nat_0) (r_0 Nat_0))
	(=> (minus_0 r_0 x_16 y_0)
	    (minus_0 (S_0 r_0) (S_0 x_16) y_0))))
(assert (forall ((y_0 Nat_0))
	(le_0 Z_0 y_0)))
(assert (forall ((x_16 Nat_0) (y_0 Nat_0))
	(=> (le_0 x_16 y_0)
	    (le_0 (S_0 x_16) (S_0 y_0)))))
(assert (forall ((y_0 Nat_0))
	(ge_0 y_0 Z_0)))
(assert (forall ((x_16 Nat_0) (y_0 Nat_0))
	(=> (ge_0 x_16 y_0)
	    (ge_0 (S_0 x_16) (S_0 y_0)))))
(assert (forall ((y_0 Nat_0))
	(lt_0 Z_0 (S_0 y_0))))
(assert (forall ((x_16 Nat_0) (y_0 Nat_0))
	(=> (lt_0 x_16 y_0)
	    (lt_0 (S_0 x_16) (S_0 y_0)))))
(assert (forall ((y_0 Nat_0))
	(gt_0 (S_0 y_0) Z_0)))
(assert (forall ((x_16 Nat_0) (y_0 Nat_0))
	(=> (gt_0 x_16 y_0)
	    (gt_0 (S_0 x_16) (S_0 y_0)))))
(assert (forall ((y_0 Nat_0))
	(mult_0 Z_0 Z_0 y_0)))
(assert (forall ((x_16 Nat_0) (y_0 Nat_0) (r_0 Nat_0) (z_1 Nat_0))
	(=>	(and (mult_0 r_0 x_16 y_0)
			(add_0 z_1 r_0 y_0))
		(mult_0 z_1 (S_0 x_16) y_0))))
(assert (forall ((x_16 Nat_0) (y_0 Nat_0))
	(=> (lt_0 x_16 y_0)
	    (div_0 Z_0 x_16 y_0))))
(assert (forall ((x_16 Nat_0) (y_0 Nat_0) (r_0 Nat_0) (z_1 Nat_0))
	(=>	(and (ge_0 x_16 y_0)
			(minus_0 z_1 x_16 y_0)
			(div_0 r_0 z_1 y_0))
		(div_0 (S_0 r_0) x_16 y_0))))
(assert (forall ((x_16 Nat_0) (y_0 Nat_0))
	(=> (lt_0 x_16 y_0)
	    (mod_0 x_16 x_16 y_0))))
(assert (forall ((x_16 Nat_0) (y_0 Nat_0) (r_0 Nat_0) (z_1 Nat_0))
	(=>	(and (ge_0 x_16 y_0)
			(minus_0 z_1 x_16 y_0)
			(mod_0 r_0 z_1 y_0))
		(mod_0 r_0 x_16 y_0))))
(declare-fun and_0 (Bool Bool Bool) Bool)
(declare-fun or_0 (Bool Bool Bool) Bool)
(declare-fun hence_0 (Bool Bool Bool) Bool)
(declare-fun not_0 (Bool Bool) Bool)
(assert (and_0 false false false))
(assert (and_0 false true false))
(assert (and_0 false false true))
(assert (and_0 true true true))
(assert (or_0 false false false))
(assert (or_0 true true false))
(assert (or_0 true false true))
(assert (or_0 true true true))
(assert (hence_0 true false false))
(assert (hence_0 false true false))
(assert (hence_0 true false true))
(assert (hence_0 true true true))
(assert (not_0 true false))
(assert (not_0 false true))
(declare-datatypes ((MutInt_0 0)) (((mutInt_1 (curInt_0 Nat_0) (retInt_0 Nat_0)))))
(declare-fun diseqMutInt_0 (MutInt_0 MutInt_0) Bool)
(declare-fun curInt_1 (Nat_0 MutInt_0) Bool)
(declare-fun retInt_1 (Nat_0 MutInt_0) Bool)
(declare-fun ismutInt_0 (MutInt_0) Bool)
(assert (forall ((x_27 MutInt_0) (x_25 Nat_0) (x_26 Nat_0))
	(=> (= x_27 (mutInt_1 x_25 x_26))
	    (curInt_1 x_25 x_27))))
(assert (forall ((x_27 MutInt_0) (x_25 Nat_0) (x_26 Nat_0))
	(=> (= x_27 (mutInt_1 x_25 x_26))
	    (retInt_1 x_26 x_27))))
(assert (forall ((x_28 Nat_0) (x_29 Nat_0))
	(ismutInt_0 (mutInt_1 x_28 x_29))))
(assert (forall ((x_30 Nat_0) (x_31 Nat_0) (x_32 Nat_0) (x_33 Nat_0))
	(=> (diseqNat_0 x_30 x_32)
	    (diseqMutInt_0 (mutInt_1 x_30 x_31) (mutInt_1 x_32 x_33)))))
(assert (forall ((x_30 Nat_0) (x_31 Nat_0) (x_32 Nat_0) (x_33 Nat_0))
	(=> (diseqNat_0 x_31 x_33)
	    (diseqMutInt_0 (mutInt_1 x_30 x_31) (mutInt_1 x_32 x_33)))))
(declare-fun justrec_0 (MutInt_0) Bool)
(declare-fun justrec_1 (MutInt_0 Bool) Bool)
(declare-fun main_0 (Bool) Bool)
(declare-fun main_1 (Bool Bool) Bool)
(assert (forall ((x_0 MutInt_0) (x_1 Bool))
	(=> (justrec_1 x_0 x_1)
	    (justrec_0 x_0))))
(assert (forall ((x_2 MutInt_0) (x_3 Nat_0) (x_4 Nat_0) (x_5 Nat_0) (x_34 Nat_0) (x_35 Nat_0))
	(=>	(and (justrec_0 (mutInt_1 x_3 x_5))
			(= x_4 x_5)
			(= x_34 x_35)
			(retInt_1 x_34 x_2)
			(curInt_1 x_35 x_2))
		(justrec_1 x_2 false))))
(assert (forall ((x_6 MutInt_0) (x_36 Nat_0) (x_37 Nat_0))
	(=>	(and (= x_36 x_37)
			(retInt_1 x_36 x_6)
			(curInt_1 x_37 x_6))
		(justrec_1 x_6 true))))
(assert (forall ((x_7 Bool) (x_8 Nat_0) (x_9 Nat_0) (x_10 Nat_0) (x_14 Bool))
	(=>	(and (justrec_0 (mutInt_1 x_8 x_10))
			(= x_9 x_10)
			(main_1 x_14 x_7)
			(gt_0 x_8 x_9)
			(not_0 x_14 true))
		(main_0 x_7))))
(assert (forall ((x_7 Bool) (x_8 Nat_0) (x_9 Nat_0) (x_10 Nat_0) (x_15 Bool))
	(=>	(and (justrec_0 (mutInt_1 x_8 x_10))
			(= x_9 x_10)
			(main_1 x_15 x_7)
			(le_0 x_8 x_9)
			(not_0 x_15 false))
		(main_0 x_7))))
(assert (forall ((x_11 Bool))
	(=> (= x_11 false)
	    (main_1 false x_11))))
(assert (forall ((x_12 Bool))
	(=> (= x_12 true)
	    (main_1 true x_12))))
(assert (forall ((x_13 Nat_0))
	(=> (main_0 true)
	    false)))
(check-sat)
(get-proof)
